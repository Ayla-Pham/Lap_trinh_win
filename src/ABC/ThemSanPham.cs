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
    public partial class ThemSanPham : Form
    {
        private DanhSachSanPhamBUS sanPhamBUS = DanhSachSanPhamBUS.Instance;
        private string selectedImagePath = null; // Biến lưu đường dẫn ảnh đã chọn
        public ThemSanPham()
        {
            InitializeComponent();
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
        }
        private void LoadLoaiSanPham()
        {
            try
            {
                cbbLoaiSanPham.DataSource = sanPhamBUS.GetLoaiSanPham();
                cbbLoaiSanPham.DisplayMember = "Tenloai";
                cbbLoaiSanPham.ValueMember = "Maloai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại sản phẩm: " + ex.Message);
            }
        }

        private void HandleImageUpload(string maSP)
        {
            if (string.IsNullOrEmpty(selectedImagePath) || string.IsNullOrEmpty(maSP))
                return;

            try
            {
                string rootPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));
                string imageFolder = Path.Combine(rootPath, "images", "products");

                if (!Directory.Exists(imageFolder))
                    Directory.CreateDirectory(imageFolder);

                string extension = Path.GetExtension(selectedImagePath);
                string newFileName = maSP + extension;
                string destinationPath = Path.Combine(imageFolder, newFileName);

                File.Copy(selectedImagePath, destinationPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thành công, nhưng lưu ảnh thất bại: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Thu thập dữ liệu
                string maSP = txtMaSanPham.Text.Trim();
                string tenSP = txtTenSanPham.Text.Trim();
                int maLoai = cbbLoaiSanPham.SelectedValue != null ? Convert.ToInt32(cbbLoaiSanPham.SelectedValue) : 0;

                if (string.IsNullOrWhiteSpace(tenSP))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (maLoai == 0)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // (BỔ SUNG) Đọc số lượng cảnh báo
                if (!int.TryParse(txtSoLuongCanhBao.Text, out int canhBao) || canhBao < 0)
                {
                    MessageBox.Show("Số lượng cảnh báo không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đọc giá bán từ trường duy nhất (txtGiaS used as single price input)
                if (!decimal.TryParse(txtGia.Text.Trim(), out decimal giaBan) || giaBan <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá bán hợp lệ (số lớn hơn 0).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Build DTO and call BUS (uses stored procedure internally)
                SanPhamDTO sp = new SanPhamDTO
                {
                    // Masp is identity, MaSP field may be used for filenames; DAO sp_ThemSanPham_Moi doesn't accept MaSP string
                    MaSP = maSP,
                    TenSP = tenSP,
                    MaLoai = maLoai,
                    GiaBan = giaBan,
                    CanhBaoTonKho = canhBao,
                    DuongDanAnh = string.IsNullOrEmpty(selectedImagePath)
                        ? null
                        : ImageHelper.DbPath(maSP + Path.GetExtension(selectedImagePath))
                };

                bool ok = sanPhamBUS.AddSanPham(sp);

                // 3. Xử lý ảnh (giữ nguyên) - use provided maSP for filename (legacy)
                HandleImageUpload(maSP);

                if (ok)
                {
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh sản phẩm";
                openFileDialog.Filter = "Ảnh (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImagePath = openFileDialog.FileName;

                        // Kiểm tra kích thước file (ví dụ: không quá 5MB)
                        FileInfo fileInfo = new FileInfo(selectedImagePath);
                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Ảnh quá lớn. Vui lòng chọn ảnh dưới 5MB.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            selectedImagePath = null;
                            return;
                        }

                        // Hiển thị ảnh
                        picAnh.Image = Image.FromFile(selectedImagePath);
                        picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                        picAnh.BorderStyle = BorderStyle.FixedSingle;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedImagePath = null;
                    }
                }

            }
        }
    }
}
