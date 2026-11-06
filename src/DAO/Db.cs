using System.Data.Linq;

namespace DAO
{
    /// <summary>
    /// Điểm tạo DataContext (LINQ to SQL, sinh từ QLCH.dbml) duy nhất cho toàn bộ DAO.
    /// Mỗi thao tác tạo một context mới: using (var db = Db.Create()) { ... }
    /// </summary>
    public static class Db
    {
        // Chuỗi kết nối nằm trong App.config (mục "DAO.Properties.Settings.QLCHConnectionString"),
        // được đọc qua DAO.Properties.Settings giống cách trình thiết kế LINQ to SQL của Visual Studio tạo ra.
        public static QLCHDataContext Create()
        {
            return new QLCHDataContext();
        }
    }

    public static class DataContextExtensions
    {
        /// <summary>
        /// SubmitChanges nhưng trả về số bản ghi được thêm/sửa/xóa
        /// (LINQ to SQL không trả về số dòng ảnh hưởng như SaveChanges của EF).
        /// </summary>
        public static int Save(this DataContext db)
        {
            ChangeSet cs = db.GetChangeSet();
            int n = cs.Inserts.Count + cs.Updates.Count + cs.Deletes.Count;
            db.SubmitChanges();
            return n;
        }

        /// <summary>
        /// Chạy nhiều lần SubmitChanges/truy vấn trong một giao dịch trên cùng một kết nối;
        /// có lỗi thì rollback toàn bộ.
        /// </summary>
        public static void RunInTransaction(this DataContext db, Action action)
        {
            db.Connection.Open();
            try
            {
                using (var tx = db.Connection.BeginTransaction())
                {
                    db.Transaction = tx;
                    try
                    {
                        action();
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                    finally
                    {
                        db.Transaction = null;
                    }
                }
            }
            finally
            {
                db.Connection.Close();
            }
        }
    }
}
