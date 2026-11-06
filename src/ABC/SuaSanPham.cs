using BUS;
using DTO;
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

namespace ABC
{
    public partial class SuaSanPham : Form
    {
        private DanhSachSanPhamBUS sanPhamBUS = DanhSachSanPhamBUS.Instance;
        private string maSP; // Mã sản phẩm đang sửa
        private string dbImagePath; // Đường dẫn ảnh đang lưu trong DB
        private string selectedImagePath = null; // Đường dẫn ảnh mới (nếu có)
        public SuaSanPham(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
        }

        private void SuaSanPham_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true; // Không cho sửa Mã SP
            txtMa.Text = this.maSP;

            LoadComboBoxes();
            LoadProductDetails();
            LoadProductImage();
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
        }
        private void LoadComboBoxes()
        {
            try
            {
                // GetLoaiSanPham trả về DataTable từ DAO -> bind trực tiếp
                cbbLoaiSanPham.DataSource = sanPhamBUS.GetLoaiSanPham();
                cbbLoaiSanPham.DisplayMember = "Tenloai";
                cbbLoaiSanPham.ValueMember = "Maloai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại sản phẩm: " + ex.Message);
            }
        }

        // Hàm chính tải thông tin lên form
        private void LoadProductDetails()
        {
            try
            {
                // Lấy thông tin sản phẩm (kích cỡ removed)
                SanPhamDTO info = sanPhamBUS.GetSanPhamTheoMaVaKichCo(this.maSP, null);
                if (info == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm.");
                    this.Close();
                    return;
                }

                dbImagePath = info.DuongDanAnh;

                // 1. Tải thông tin cơ bản
                txtTen.Text = info.TenSP;
                // MaLoai trong DTO mapped as MaLoai
                if (info.MaLoai != 0 && cbbLoaiSanPham.Items.Count > 0)
                {
                    try { cbbLoaiSanPham.SelectedValue = info.MaLoai; } catch { }
                }

                // Nếu DB có CanhBaoTonKho thì hiển thị (SanPhamDTO có trường CanhBaoTonKho)
                txtSoLuongCanhBao.Text = info.CanhBaoTonKho.ToString();

                // 2. Vì kích cỡ đã bị remove, dùng single price control (txtSuaGiaS) to show GiaBan
                try
                {
                    txtGia.Text = info.GiaBan.ToString("F0");
                }
                catch { /* Ignore if control missing */ }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết sản phẩm: " + ex.Message);
            }
        }

        // Tải ảnh (dựa trên MaSP)
        private void LoadProductImage()
        {
            try
            {
                // Ưu tiên ảnh theo đường dẫn lưu trong DB
                if (ImageHelper.ResolvePath(dbImagePath) != null)
                {
                    picAnhSua.Image?.Dispose();
                    picAnhSua.Image = ImageHelper.LoadImage(dbImagePath);
                    picAnhSua.SizeMode = PictureBoxSizeMode.Zoom;
                    return;
                }

                string rootPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));
                string imagesFolder = Path.Combine(rootPath, "images", "products");

                string[] extensions = { ".png", ".jpg", ".jpeg", ".gif" };
                string imagePath = null;

                foreach (string ext in extensions)
                {
                    string path = Path.Combine(imagesFolder, this.maSP + ext);
                    if (File.Exists(path))
                    {
                        imagePath = path;
                        break;
                    }
                }

                if (imagePath != null)
                {
                    if (picAnhSua.Image != null)
                        picAnhSua.Image.Dispose();

                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        picAnhSua.Image = Image.FromStream(ms);
                    }
                    picAnhSua.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { /* Bỏ qua nếu lỗi */ }
        }

        private void HandleImageUpload(string maSP)
        {
            if (string.IsNullOrEmpty(selectedImagePath) || string.IsNullOrEmpty(maSP))
                return;

            try
            {
                // Đi lên thư mục gốc dự án (src/ABC)
                string rootPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));
                string imagesFolder = Path.Combine(rootPath, "images", "products");

                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                string extension = Path.GetExtension(selectedImagePath);
                string newFileName = maSP + extension;
                string destinationPath = Path.Combine(imagesFolder, newFileName);

                // Giải phóng file nếu đang bị giữ bởi PictureBox
                if (File.Exists(destinationPath))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                // Ghi đè ảnh mới
                File.Copy(selectedImagePath, destinationPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công, nhưng lưu ảnh thất bại: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // (BỔ SUNG) Đọc số lượng cảnh báo
                if (!int.TryParse(txtSoLuongCanhBao.Text, out int canhBao) || canhBao < 0)
                {
                    MessageBox.Show("Số lượng cảnh báo không hợp lệ.");
                    return;
                }

                // Read price from single control txtSuaGiaS
                if (!decimal.TryParse(txtGia.Text.Trim(), out decimal giaBan) || giaBan < 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ.");
                    return;
                }

                // Resolve numeric Masp
                int maspInt = sanPhamBUS.GetMasp(this.maSP);
                if (maspInt == 0)
                {
                    // try parse directly if user provided numeric string
                    int.TryParse(this.maSP, out maspInt);
                }

                if (maspInt == 0)
                {
                    MessageBox.Show("Không xác định được Mã sản phẩm để cập nhật.");
                    return;
                }

                SanPhamDTO sp = new SanPhamDTO
                {
                    Masp = maspInt,
                    TenSP = txtTen.Text.Trim(),
                    MaLoai = cbbLoaiSanPham.SelectedValue != null ? Convert.ToInt32(cbbLoaiSanPham.SelectedValue) : 0,
                    GiaBan = giaBan,
                    DuongDanAnh = selectedImagePath != null
                        ? ImageHelper.DbPath(this.maSP + Path.GetExtension(selectedImagePath))
                        : null,   // null = giữ ảnh cũ
                    CanhBaoTonKho = canhBao
                };

                bool ok = sanPhamBUS.UpdateSanPham(sp);

                // 2. Xử lý ảnh (giữ nguyên)
                if (selectedImagePath != null)
                {
                    HandleImageUpload(this.maSP);
                }

                if (ok)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedImagePath = openFileDialog.FileName; // Lưu đường dẫn

                    // Giải phóng ảnh cũ (nếu có)
                    if (picAnhSua.Image != null)
                    {
                        picAnhSua.Image.Dispose();
                    }

                    // Tải ảnh vào MemoryStream để không khóa file
                    // Đọc tất cả byte của file vào bộ nhớ
                    byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        // Tạo ảnh từ bộ nhớ (stream)
                        picAnhSua.Image = Image.FromStream(ms);
                    }

                    picAnhSua.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    selectedImagePath = null;
                }
            }
        }
    }
}
