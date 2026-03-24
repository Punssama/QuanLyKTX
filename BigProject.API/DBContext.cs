using Microsoft.EntityFrameworkCore;
namespace BigProject.API
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options) { }
        public DbSet<Models.TaiKhoan> TaiKhoans { get; set; }
        public DbSet<Models.PhongO> PhongOs { get; set; }
        public DbSet<Models.HopDong> HopDongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.TaiKhoan>()
                .HasIndex(tk => tk.TenDangNhap)
                .HasDatabaseName("Idx_TenDangNhap");
        }
    }
}
