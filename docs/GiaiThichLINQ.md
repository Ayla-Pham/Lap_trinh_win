# Giải thích việc chuyển dự án sang LINQ to SQL (.dbml)

Tài liệu này giúp các thành viên trong nhóm hiểu dự án đã đổi **cách truy cập dữ liệu** như thế nào,
vì sao đổi, và khi cần sửa/thêm chức năng thì làm ở đâu.

---

## 1. Tóm tắt trong 30 giây

| | **Trước** | **Sau** |
|---|---|---|
| Cách truy cập DB | ADO.NET: viết câu lệnh SQL / gọi stored procedure | **LINQ to SQL**: viết truy vấn bằng C# (LINQ) |
| Dữ liệu trả về | `DataTable`, `DataRow` | Danh sách đối tượng (`List<...DTO>`) |
| Ánh xạ bảng ↔ lớp | Tự viết tay | File **`QLCH.dbml`** (thiết kế) → `QLCH.designer.cs` (tự sinh) |
| Stored procedure | Rất nhiều (`sp_...`) | **Không còn dùng cái nào** |
| Nền tảng | .NET 8 | **.NET Framework 4.8** (để dùng được LINQ to SQL + file .dbml) |

Kiến trúc 3 lớp **không đổi**: `ABC` (giao diện) → `BUS` (nghiệp vụ) → `DAO` (truy cập dữ liệu) → CSDL;
`DTO` là các lớp chứa dữ liệu đi giữa các lớp. **Hầu như toàn bộ thay đổi nằm ở lớp DAO.**

---

## 2. Vì sao phải đổi sang .NET Framework 4.8?

Thầy yêu cầu dùng LINQ thông qua file `.dbml` (mục *LINQ to SQL Classes* của Visual Studio).
Trình thiết kế `.dbml` và thư viện `System.Data.Linq` chỉ hỗ trợ đầy đủ trên **.NET Framework**,
không có trên .NET 8. Vì vậy cả 4 project (`ABC`, `BUS`, `DAO`, `DTO`) được đổi sang `net48`.

> Lúc đầu có thử Entity Framework Core (cũng là LINQ nhưng không có file .dbml) trên .NET 8,
> sau đó đã thay thế hoàn toàn bằng LINQ to SQL. EF Core hiện không còn trong dự án.

---

## 3. Các thành phần mới cần biết

Tất cả nằm trong thư mục `src/DAO/`:

| File | Vai trò |
|---|---|
| **`QLCH.dbml`** | File thiết kế LINQ to SQL: mô tả các bảng, cột, khóa chính/ngoại của CSDL `QLCH`. Mở bằng Visual Studio sẽ thấy sơ đồ các bảng. |
| **`QLCH.designer.cs`** | **Tự sinh** từ `.dbml`. Chứa lớp `QLCHDataContext` và mỗi bảng thành một lớp (`KHACHHANG`, `HOADON`, `SANPHAM`...). **Không sửa tay.** |
| **`Db.cs`** | `Db.Create()` tạo một `QLCHDataContext` mới. Có thêm 2 hàm tiện ích: `Save()` và `RunInTransaction()` (xem mục 6, 7). |
| **`Properties/Settings.settings`** | Giữ chuỗi kết nối mặc định cho `.dbml`. |
| `*DAO.cs` | Các lớp DAO — chỗ viết truy vấn LINQ. |

`QLCHDataContext` là **cầu nối** giữa code C# và CSDL: mỗi bảng là một thuộc tính trên context, ví dụ
`db.KHACHHANGs`, `db.HOADONs`, `db.SANPHAMs`. Mỗi dòng của bảng là một đối tượng (`KHACHHANG`, `HOADON`...).

### Chuỗi kết nối
Nằm trong `src/ABC/App.config`, tên mục là **`DAO.Properties.Settings.QLCHConnectionString`**
(đúng quy ước mà Visual Studio tự tạo khi kéo bảng vào .dbml). Muốn trỏ sang máy SQL Server khác
chỉ cần sửa chuỗi này (ví dụ `.\SQL2022` hoặc `.\SQLEXPRESS`).

---

## 4. Ví dụ so sánh trước / sau

### Đọc dữ liệu — lấy danh sách khách hàng

**Trước (ADO.NET):**
```csharp
string query = "SELECT * FROM KHACHHANG";
DataTable data = DataProvider.Instance.ExecuteQuery(query);
foreach (DataRow row in data.Rows)
    dsKH.Add(new KhachHangDTO(row));
```

**Sau (LINQ to SQL):**
```csharp
using (var db = Db.Create())
{
    return db.KHACHHANGs
        .Select(k => new KhachHangDTO(k.Makh, k.Tenkh, k.Sdt, k.Tichdiem))
        .ToList();
}
```

### Tìm kiếm có điều kiện
```csharp
// SQL:  SELECT * FROM KHACHHANG WHERE Tenkh LIKE '%a%' OR Sdt LIKE '%a%'
db.KHACHHANGs
  .Where(k => k.Tenkh.Contains(keyword) || k.Sdt.Contains(keyword))
  .Select(k => new KhachHangDTO(k.Makh, k.Tenkh, k.Sdt, k.Tichdiem))
  .ToList();
```

### Thêm / sửa / xóa
```csharp
// Thêm
db.KHACHHANGs.InsertOnSubmit(new KHACHHANG { Tenkh = "A", Sdt = "09...", Tichdiem = 0 });
db.Save();

// Sửa: lấy đối tượng, đổi thuộc tính, lưu
var k = db.KHACHHANGs.First(x => x.Makh == id);
k.Tichdiem = 5;
db.Save();

// Xóa
db.KHACHHANGs.DeleteOnSubmit(k);
db.Save();
```
Điểm quan trọng: LINQ to SQL **theo dõi thay đổi** của đối tượng; chỉ khi gọi `SubmitChanges()`
(ở đây là `db.Save()`) thì mới thực sự ghi xuống CSDL.

---

## 5. Bảng quy đổi SQL ↔ LINQ hay dùng trong dự án

| SQL | LINQ |
|---|---|
| `WHERE` | `.Where(x => ...)` |
| `LIKE '%a%'` | `.Contains("a")` |
| `SELECT cột1, cột2` | `.Select(x => new { x.A, x.B })` hoặc `new XxxDTO { ... }` |
| `ORDER BY ... DESC` | `.OrderByDescending(x => x.Ngay)` |
| `TOP 10` | `.Take(10)` |
| `GROUP BY` + `SUM` | `.GroupBy(...).Select(g => new { g.Key, Tong = g.Sum(...) })` |
| `JOIN` | Dùng thuộc tính quan hệ: `ct.SANPHAM.Tensp`, `h.NHANVIEN.Hoten` (không cần viết JOIN) |
| `LEFT JOIN` | `from ap in h.APMAVCs.DefaultIfEmpty()` |
| `EXISTS` / `COUNT > 0` | `.Any(x => ...)` |
| `SELECT TOP 1` | `.FirstOrDefault()` |
| `ISNULL(a, 0)` | `a ?? 0` |
| `NOT NULL / IS NULL` | `x.Cot != null` / `x.Cot == null` |

Nhờ **thuộc tính quan hệ** (khóa ngoại trong `.dbml`), thay vì viết `JOIN` ta chỉ "chấm" tới bảng liên quan:
```csharp
db.CHITIETHDs.Where(ct => ct.Mahd == maHD)
  .Select(ct => new { ct.SANPHAM.Tensp, ct.Soluong, ct.Dongia });
```

---

## 6. `Save()` – vì sao có hàm này?

`SubmitChanges()` của LINQ to SQL trả về `void`, trong khi code cũ cần biết "có ghi được dòng nào không"
(`return rows > 0`). `db.Save()` (trong `Db.cs`) gọi `SubmitChanges()` và trả về **số bản ghi thêm/sửa/xóa**,
nên có thể viết `return db.Save() > 0;`.

---

## 7. Giao dịch (transaction)

Các nghiệp vụ nhiều bước phải "thành công hết hoặc hủy hết": **lập hóa đơn, trả hàng, nhập kho, xuất kho**.
Chúng dùng `db.RunInTransaction(() => { ... })`:

```csharp
db.RunInTransaction(() =>
{
    db.HOADONs.InsertOnSubmit(hoaDon);
    db.SubmitChanges();                       // lấy được Mahd tự tăng
    // ... thêm chi tiết, áp voucher, trừ tồn kho ...
    db.SubmitChanges();
});   // có lỗi ở bất kỳ bước nào -> tự rollback
```
Ví dụ: xuất kho khi tồn không đủ sẽ ném lỗi → toàn bộ phiếu xuất bị hủy, tồn kho không bị trừ dở dang.

---

## 8. Hai bảng nối (quan hệ nhiều–nhiều)

LINQ to SQL **không** tự ẩn bảng trung gian như EF. Hai bảng này là các lớp bình thường:

- `APMAVC` — voucher đã áp dụng cho hóa đơn (`Mahd`, `Mavc`)
- `VOUCHER_SANPHAM` — sản phẩm thuộc voucher (`Mavc`, `Masp`)

Ví dụ lấy sản phẩm của một voucher:
```csharp
db.VOUCHER_SANPHAMs.Where(vs => vs.Mavc == mavc).Select(vs => vs.SANPHAM);
```

---

## 9. Thay đổi ở BUS và giao diện (ABC)

- Các hàm trước đây trả `DataTable` nay trả **`List<DTO>`** (ví dụ `List<NhanVienGridDTO>`,
  `List<VoucherHienThiDTO>`, `List<LoaiVoucherDTO>`). Các DTO mới này nằm trong `src/DTO/`.
- `DataGridView.DataSource` gán trực tiếp `List<DTO>`; **tên thuộc tính của DTO = tên cột** hiển thị.
- Lọc dữ liệu trên form (ô tìm kiếm, combobox lọc) trước dùng `DataView.RowFilter`, nay dùng LINQ:
  ```csharp
  dgvNhanVien.DataSource = ds.Where(nv => nv.Vitri == tieuChiLoc).ToList();
  ```
- ComboBox dùng `DisplayMember`/`ValueMember` trỏ tới **thuộc tính** của DTO (ví dụ `"TenLoai"`, `"MaLoai"`).
- Các form **không còn tự mở kết nối SQL** (`TraHang`, `LichSuTraHang` trước đây vi phạm kiến trúc);
  việc đó đã chuyển xuống DAO/BUS.

---

## 10. Các "bẫy" đã gặp (đọc để khỏi mắc lại)

1. **`Sum` trên tập rỗng trả `null`.** Viết `.Sum(x => (int?)x.Cot) ?? 0` thay vì `.Sum(x => x.Cot)`.
2. **Không dùng `DateOnly`/`TimeOnly`** (chỉ có từ .NET 6). Cột kiểu `date` được ánh xạ sang `DateTime`.
3. **Cột tính toán** (`Thanhtien` trong `CHITIETHD`, `CHITIETNHAPKHO`) đã đánh dấu *IsDbGenerated* trong `.dbml`
   để không bị ghi đè khi insert. Đừng gán giá trị cho các cột này.
4. **Không chỉnh sửa `QLCH.designer.cs` bằng tay** — mọi thay đổi làm trong `QLCH.dbml`
   rồi để Visual Studio sinh lại.
5. **Đường dẫn ảnh** trong CSDL dạng `/images/coca.jpg` (có dấu `/` đầu). Dùng `ImageHelper.LoadImage(...)`
   để nạp ảnh, đừng tự `Path.Combine`.
6. **Phông chữ form**: form thiết kế cho Segoe UI 9pt, nên mỗi form đặt `Font = Segoe UI 9` ở đầu
   `InitializeComponent()`; nếu không, .NET Framework dùng phông khác làm form bị co lại/cắt menu.

---

## 11. Muốn thêm bảng / cột mới thì làm sao?

1. Mở `src/DAO/QLCH.dbml` bằng Visual Studio (cần cài **LINQ to SQL tools**:
   Visual Studio Installer → *Modify* → *Individual components* → tìm "LINQ to SQL tools").
2. Từ **Server Explorer** kéo bảng mới vào màn hình thiết kế. Lưu lại → `QLCH.designer.cs` tự sinh lại.
3. Nếu CSDL **đổi cột** của bảng đã có: xóa bảng đó khỏi sơ đồ rồi kéo lại.
4. Viết truy vấn mới trong file `*DAO.cs` tương ứng, rồi gọi qua BUS.

---

## 12. Chạy dự án trên máy của mình

1. Mở `ABC.sln` bằng Visual Studio 2022 (có workload *.NET desktop development*).
2. Sửa chuỗi kết nối trong `src/ABC/App.config` cho đúng tên SQL Server của máy bạn.
3. Chạy project **ABC**.

Bảng và dữ liệu mẫu nằm trong `src/DAO/QLCH.mdf` (hoặc restore từ script của nhóm).

---

## 13. Những điều chưa chắc / cần kiểm tra

- Một số stored procedure cũ **không có trong CSDL/mdf của repo** (ví dụ `sp_CheckDangNhap`, `sp_TaoHoaDon`,
  `sp_TruTonKho`...). Logic của chúng được **suy ra từ tên và cách gọi**. Khi chạy bằng CSDL thật của nhóm,
  hãy kiểm tra: đăng nhập, lập hóa đơn (trừ tồn kho), tìm nhân viên, sản phẩm tặng của voucher.
- Các truy vấn trong DAO đã được chạy thử với CSDL thật (đọc, ghi thử, rollback giao dịch),
  nhưng **giao diện chưa được kiểm tra đầy đủ từng form**. Phát hiện lỗi hiển thị thì báo lại để sửa.
