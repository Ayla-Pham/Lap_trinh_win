using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ABC
{
    /// <summary>
    /// Xử lý đường dẫn và nạp ảnh sản phẩm. Đường dẫn trong DB dạng "/images/coca.jpg"
    /// (có dấu "/" ở đầu) nên phải bỏ dấu này trước khi ghép với thư mục gốc,
    /// nếu không Path.Combine sẽ bỏ qua thư mục gốc.
    /// </summary>
    public static class ImageHelper
    {
        // Thư mục gốc dự án (src/ABC) khi chạy từ bin/Debug/net8.0-windows
        public static string RootPath =>
            Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));

        // Trả về đường dẫn tuyệt đối của ảnh (null nếu không tìm thấy file)
        public static string ResolvePath(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
                return null;

            string rel = relativePath.Trim()
                .TrimStart('/', '\\')
                .Replace('/', Path.DirectorySeparatorChar);

            string[] roots = { RootPath, AppContext.BaseDirectory };
            foreach (string root in roots)
            {
                string full = Path.Combine(root, rel);
                if (File.Exists(full))
                    return full;
            }
            return null;
        }

        // Nạp ảnh không khóa file; trả về ảnh "no image" nếu không có
        public static Image LoadImage(string relativePath)
        {
            string full = ResolvePath(relativePath);
            if (full != null)
            {
                try
                {
                    using (var ms = new MemoryStream(File.ReadAllBytes(full)))
                    using (var img = Image.FromStream(ms))
                    {
                        // Sao chép sang Bitmap độc lập với stream
                        return new Bitmap(img);
                    }
                }
                catch { /* rơi xuống ảnh mặc định */ }
            }
            return Properties.Resources.no_image;
        }

        // Tạo đường dẫn tương đối lưu vào DB cho ảnh đã lưu trong images/products
        public static string DbPath(string fileName) => "images/products/" + fileName;
    }
}
