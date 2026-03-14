using Microsoft.EntityFrameworkCore;
namespace BigProject.API
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options) { }
        public DbSet<Models.TaiKhoan> TaiKhoans { get; set; }

    }
}
