using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfFont = iTextSharp.text.Font;

namespace ABC
{
    public partial class DANHSACHSANPHAM : Form
    {
        private DanhSachSanPhamBUS sanPhamBUS = new DanhSachSanPhamBUS();

        // Dùng Dictionary để map tên hiển thị và giá trị thực tế cho ComboBox
        private Dictionary<string, string> searchTypes = new Dictionary<string, string>();
        private string FONT_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "times.ttf");
        private BaseFont vietnameseFont;
        public DANHSACHSANPHAM()
        {
            InitializeComponent();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSanPham themSanPham = new ThemSanPham();
            if (themSanPham.ShowDialog() == DialogResult.OK)
            {
                LoadDataGrid(); // Gọi lại để cập nhật danh sách
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn dòng nào chưa
            if (dgvDanhSachSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy MaSP từ dòng đã chọn (string mã hoặc numeric id)
                string maSPCanSua = dgvDanhSachSanPham.CurrentRow.Cells["MaSP"].Value.ToString();

                // 3. Mở form Sửa và truyền MaSP vào
                SuaSanPham suaSanPham = new SuaSanPham(maSPCanSua); // <-- Truyền maSP vào đây

                // Dùng ShowDialog() để nó khóa form cha lại
                suaSanPham.ShowDialog();

                // 4. Sau khi form Sửa đóng, tải lại lưới
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở form sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DANHSACHSANPHAM_Load(object sender, EventArgs e)
        {
            LoadSearchComboBox();
            LoadDataGrid(); // Tải tất cả sản phẩm khi form mở
            SetupDataGridView();
            InitializePdfFont();
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvDanhSachSanPham);
        }
        private void InitializePdfFont()
        {
            try
            {
                if (!File.Exists(FONT_PATH))
                {
                    MessageBox.Show($"Không tìm thấy file font tại: {FONT_PATH}\nKhông thể xuất PDF Tiếng Việt.", "Lỗi Font", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                vietnameseFont = BaseFont.CreateFont(FONT_PATH, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải font Tiếng Việt cho PDF: " + ex.Message, "Lỗi Font", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSearchComboBox()
        {
            searchTypes.Add("Mã sản phẩm", "MaSP");
            searchTypes.Add("Tên sản phẩm", "TenSP");
            searchTypes.Add("Loại sản phẩm", "LoaiSP");

            cbbLoaiTimKiem.DataSource = new BindingSource(searchTypes, null);
            cbbLoaiTimKiem.DisplayMember = "Key";
            cbbLoaiTimKiem.ValueMember = "Value";
        }

        // Cấu hình hiển thị cho DataGridView
        private void SetupDataGridView()
        {
            // Guard: check columns exist before referencing them
            if (dgvDanhSachSanPham.Columns.Contains("Masp"))
                dgvDanhSachSanPham.Columns["Masp"].HeaderText = "ID";
            if (dgvDanhSachSanPham.Columns.Contains("MaSP"))
                dgvDanhSachSanPham.Columns["MaSP"].HeaderText = "Mã SP";
            if (dgvDanhSachSanPham.Columns.Contains("TenSP"))
                dgvDanhSachSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            if (dgvDanhSachSanPham.Columns.Contains("TenLoai"))
                dgvDanhSachSanPham.Columns["TenLoai"].HeaderText = "Loại";
            if (dgvDanhSachSanPham.Columns.Contains("GiaBan"))
                dgvDanhSachSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
            if (dgvDanhSachSanPham.Columns.Contains("SoLuongTon"))
                dgvDanhSachSanPham.Columns["SoLuongTon"].HeaderText = "Tồn Kho";
            if (dgvDanhSachSanPham.Columns.Contains("TrangThaiText"))
                dgvDanhSachSanPham.Columns["TrangThaiText"].HeaderText = "Trạng Thái";

            if (dgvDanhSachSanPham.Columns.Contains("GiaBan"))
                dgvDanhSachSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";

            if (dgvDanhSachSanPham.Columns.Contains("Masp"))
                dgvDanhSachSanPham.Columns["Masp"].Visible = false;

            if (dgvDanhSachSanPham.Columns.Contains("GiaGoc"))
                dgvDanhSachSanPham.Columns["GiaGoc"].Visible = false;
            if (dgvDanhSachSanPham.Columns.Contains("TienGiam"))
                dgvDanhSachSanPham.Columns["TienGiam"].Visible = false;
            if (dgvDanhSachSanPham.Columns.Contains("LoaiVoucher"))
                dgvDanhSachSanPham.Columns["LoaiVouCher"].Visible = false;
            if (dgvDanhSachSanPham.Columns.Contains("PhanTramGiam"))
                dgvDanhSachSanPham.Columns["PhanTramGiam"].Visible = false;
        }

        // Hàm tải/tải lại dữ liệu cho DataGridView
        private void LoadDataGrid(string searchType = null, string searchTerm = null)
        {
            try
            {
                // 1. Lấy danh sách sản phẩm từ BUS
                var danhSach = sanPhamBUS.SearchSanPham(searchType, searchTerm);

                // 2. Gán vào DataGridView
                dgvDanhSachSanPham.DataSource = danhSach;
                if (dgvDanhSachSanPham.Columns.Contains("DuongDanAnh"))
                    dgvDanhSachSanPham.Columns["DuongDanAnh"].Visible = false;
                if (dgvDanhSachSanPham.Columns.Contains("LaSanPhamTang"))
                    dgvDanhSachSanPham.Columns["LaSanPhamTang"].Visible = false;
                if (dgvDanhSachSanPham.Columns.Contains("SoLuong"))
                    dgvDanhSachSanPham.Columns["SoLuong"].Visible = false;
                if (dgvDanhSachSanPham.Columns.Contains("MaSanPhamGoc"))
                    dgvDanhSachSanPham.Columns["MaSanPhamGoc"].Visible = false;
                if (dgvDanhSachSanPham.Columns.Contains("Maloai"))
                    dgvDanhSachSanPham.Columns["Maloai"].HeaderText = "Mã loại sản phẩm";
                // 3. Thêm cột ảnh nếu chưa có
                if (!dgvDanhSachSanPham.Columns.Contains("Anh"))
                {
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.Name = "Anh";
                    imgCol.HeaderText = "Ảnh";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgvDanhSachSanPham.Columns.Insert(0, imgCol); // chèn vào đầu
                }

                // 4. Gán ảnh cho từng dòng
                foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
                {
                    if (dgvDanhSachSanPham.Columns.Contains("DuongDanAnh") && row.Cells["DuongDanAnh"] != null && row.Cells["DuongDanAnh"].Value != null)
                    {
                        row.Cells["Anh"].Value = ImageHelper.LoadImage(row.Cells["DuongDanAnh"].Value.ToString());
                    }
                    else
                    {
                        row.Cells["Anh"].Value = Properties.Resources.no_image;
                    }
                }

                // 5. Đặt tên cột sau khi gán DataSource (guarded)
                if (dgvDanhSachSanPham.Columns.Contains("Masp"))
                    dgvDanhSachSanPham.Columns["Masp"].HeaderText = "ID";
                if (dgvDanhSachSanPham.Columns.Contains("MaSP"))
                    dgvDanhSachSanPham.Columns["MaSP"].HeaderText = "Mã SP";
                if (dgvDanhSachSanPham.Columns.Contains("TenSP"))
                    dgvDanhSachSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                if (dgvDanhSachSanPham.Columns.Contains("TenLoai"))
                    dgvDanhSachSanPham.Columns["TenLoai"].HeaderText = "Loại";
                if (dgvDanhSachSanPham.Columns.Contains("GiaBan"))
                    dgvDanhSachSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
                if (dgvDanhSachSanPham.Columns.Contains("SoLuongTon"))
                    dgvDanhSachSanPham.Columns["SoLuongTon"].HeaderText = "Tồn Kho";
                if (dgvDanhSachSanPham.Columns.Contains("TrangThaiText"))
                    dgvDanhSachSanPham.Columns["TrangThaiText"].HeaderText = "Trạng Thái";

                if (dgvDanhSachSanPham.Columns.Contains("GiaBan"))
                    dgvDanhSachSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
                if (dgvDanhSachSanPham.Columns.Contains("Masp"))
                    dgvDanhSachSanPham.Columns["Masp"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchType = cbbLoaiTimKiem.SelectedValue.ToString();
            string searchTerm = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu ô tìm kiếm rỗng, tải lại tất cả
                LoadDataGrid();
            }
            else
            {
                // Nếu có chữ, bắt đầu tìm
                LoadDataGrid(searchType, searchTerm);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnHien_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần Ẩn/Hiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedID = 0;
                if (dgvDanhSachSanPham.Columns.Contains("Masp") && dgvDanhSachSanPham.CurrentRow.Cells["Masp"].Value != null)
                    selectedID = Convert.ToInt32(dgvDanhSachSanPham.CurrentRow.Cells["Masp"].Value);
                else
                {
                    MessageBox.Show("Không tìm thấy ID sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tenSP = dgvDanhSachSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
                string trangThaiHienTai = dgvDanhSachSanPham.CurrentRow.Cells["TrangThaiText"].Value.ToString();
                string trangThaiMoi = (trangThaiHienTai == "Đang bán") ? "Ngừng bán" : "Đang bán";

                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn đổi trạng thái của '{tenSP}' từ '{trangThaiHienTai}' thành '{trangThaiMoi}' không?",
                    "Xác nhận Ẩn/Hiện",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    bool success = sanPhamBUS.ToggleTrangThaiSanPham(selectedID);

                    if (success)
                    {
                        MessageBox.Show("Đã cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật trạng thái thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin
                int selectedID = 0;
                if (dgvDanhSachSanPham.Columns.Contains("Masp") && dgvDanhSachSanPham.CurrentRow.Cells["Masp"].Value != null)
                    selectedID = Convert.ToInt32(dgvDanhSachSanPham.CurrentRow.Cells["Masp"].Value);
                else
                {
                    MessageBox.Show("Không tìm thấy ID sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maSP = dgvDanhSachSanPham.CurrentRow.Cells["MaSP"].Value.ToString(); // <-- LẤY MaSP hiển thị
                string tenSP = dgvDanhSachSanPham.CurrentRow.Cells["TenSP"].Value.ToString();

                // Xác nhận
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn XÓA vĩnh viễn '{tenSP}'?\n" +
                    $"Sản phẩm mã: {maSP}",
                    "Xác nhận Xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    // Gọi BUS
                    bool success = sanPhamBUS.DeleteSanPham(selectedID, maSP); // <-- Truyền cả ID và MaSP

                    if (success)
                    {
                        MessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("REFERENCE constraint"))
                {
                    MessageBox.Show("Không thể xóa sản phẩm vì đã tồn tại trong hóa đơn/phiếu nhập.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            if (vietnameseFont == null)
            {
                MessageBox.Show("Chưa tải được font Tiếng Việt. Không thể xuất PDF.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvDanhSachSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"DanhSachSanPham_{DateTime.Now:ddMMyyyy_HHmmss}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportDataGridViewToPdf(dgvDanhSachSanPham, saveFileDialog.FileName);
                    MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveFileDialog.FileName)
                    {
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExportDataGridViewToPdf(DataGridView dgv, string filePath)
        {
            // 1. Định nghĩa Font
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(vietnameseFont, 20f, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(vietnameseFont, 14f, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font cellFont = new iTextSharp.text.Font(vietnameseFont, 10f, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font timestampFont = new iTextSharp.text.Font(vietnameseFont, 11f, iTextSharp.text.Font.ITALIC);

            // 2. Tạo Document
            Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f); // Trang ngang
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // 3. Thêm Tiêu đề
            Paragraph title = new Paragraph("DANH SÁCH SẢN PHẨM", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 5;
            document.Add(title);

            // 3b. Thêm Ngày giờ xuất
            string thoiGianXuat = $"(Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss})";
            Paragraph timestamp = new Paragraph(thoiGianXuat, timestampFont);
            timestamp.Alignment = Element.ALIGN_CENTER;
            timestamp.SpacingAfter = 15;
            document.Add(timestamp);

            // 4. Tạo Bảng (Table)

            // Đếm số cột đang hiển thị và +1 cho cột STT
            int columnCount = 1; // Bắt đầu với 1 cho cột STT
            List<DataGridViewColumn> visibleColumns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                // Chỉ lấy các cột đang được cho phép hiển thị (Visible = true)
                if (column.Visible)
                {
                    columnCount++;
                    visibleColumns.Add(column);
                }
            }

            PdfPTable pdfTable = new PdfPTable(columnCount);
            pdfTable.WidthPercentage = 100;

            // 5. Thêm Header cho bảng

            // Thêm cột "STT" làm cột đầu tiên
            PdfPCell sttHeaderCell = new PdfPCell(new Phrase("STT", headerFont));
            sttHeaderCell.HorizontalAlignment = Element.ALIGN_CENTER;
            sttHeaderCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            sttHeaderCell.BackgroundColor = new BaseColor(230, 230, 230); // Màu nền header
            sttHeaderCell.Padding = 5;
            pdfTable.AddCell(sttHeaderCell);

            // Thêm các header cột khác (chỉ các cột visible)
            foreach (DataGridViewColumn column in visibleColumns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.BackgroundColor = new BaseColor(230, 230, 230);
                cell.Padding = 5;
                pdfTable.AddCell(cell);
            }

            // 6. Thêm Dữ liệu (Dòng)

            // Dùng for loop để lấy index làm STT (i + 1)
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                // Thêm cell STT
                string stt = (i + 1).ToString();
                PdfPCell sttCell = new PdfPCell(new Phrase(stt, cellFont));
                sttCell.HorizontalAlignment = Element.ALIGN_CENTER; // Canh giữa STT
                sttCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                sttCell.Padding = 5;
                pdfTable.AddCell(sttCell);

                // Thêm các cell dữ liệu (chỉ các cột visible)
                foreach (DataGridViewColumn column in visibleColumns)
                {
                    // Lấy cell bằng index của cột
                    DataGridViewCell cell = dgv.Rows[i].Cells[column.Index];

                    string cellValue = cell.Value?.ToString() ?? "";

                    // Định dạng lại cột giá (bỏ .000)
                    if (column.Name == "GiaBan")
                    {
                        if (decimal.TryParse(cellValue, out decimal gia))
                        {
                            cellValue = gia.ToString("N0");
                        }
                    }

                    PdfPCell pdfCell = new PdfPCell(new Phrase(cellValue, cellFont));
                    pdfCell.Padding = 5;

                    // Căn lề
                    if (column.Name == "GiaBan" || column.Name == "SoLuongTon")
                    {
                        pdfCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Căn phải cho số
                    }
                    else
                    {
                        pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    }

                    pdfTable.AddCell(pdfCell);
                }
            }

            // 7. Thêm bảng vào document
            document.Add(pdfTable);

            // 8. Đóng file
            document.Close();
            writer.Close();
        }

        private void dgvDanhSachSanPham_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự (bắt đầu từ 1)
            string soThuTu = (e.RowIndex + 1).ToString();

            // Tạo brush màu
            SolidBrush brush = new SolidBrush(Color.Black); // Màu chữ STT

            // Tạo hình chữ nhật cho ô header
            System.Drawing.Rectangle headerBounds = new System.Drawing.Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dgvDanhSachSanPham.RowHeadersWidth,
                e.RowBounds.Height
            );

            // Canh lề giữa
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Vẽ số thứ tự vào giữa ô header
            e.Graphics.DrawString(
                soThuTu,
                this.Font, // Dùng font của form
                brush,
                headerBounds, // Vẽ vào hình chữ nhật này
                format        // Dùng định dạng canh giữa
            );
        }
    }
}
