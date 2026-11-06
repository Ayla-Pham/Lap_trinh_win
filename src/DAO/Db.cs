using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    /// <summary>
    /// Điểm tạo DbContext duy nhất cho toàn bộ DAO. Mỗi thao tác tạo một context mới
    /// (using var db = Db.Create();) để tránh giữ kết nối/ cache cũ.
    /// </summary>
    public static class Db
    {
        public static string ConnectionString =>
            System.Configuration.ConfigurationManager.ConnectionStrings["QUANLICHTL"].ConnectionString;

        public static QLCHContext Create()
        {
            var options = new DbContextOptionsBuilder<QLCHContext>()
                .UseSqlServer(ConnectionString)
                .Options;
            return new QLCHContext(options);
        }
    }
}
