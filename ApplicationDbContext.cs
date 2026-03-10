using Microsoft.EntityFrameworkCore;

namespace DuAnDauTien.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Cuộc sống" },
                new Category { CategoryId = 2, CategoryName = "Lập trình" },
                new Category { CategoryId = 3, CategoryName = "Sức khỏe" }
            );

            
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Cho tôi xin một vé đi tuổi thơ",
                    Author = "Nguyễn Nhật Ánh",
                    Price = 61000,
                    Description = "Đàn ông tuổi 15 mơ ước thành đàn ông tuổi 20, đàn ông tuổi 20 mơ ước thành đàn ông tuổi 30, đàn ông tuổi 30 mơ ước được trở thành đàn ông tuổi 40 và đàn ông tuổi 40 lại mơ ước đặt chân lên cổ máy thời gian để quay lại tuổi 30 với toàn bộ tài sản của mình! Vậy đấy!",
                    Image = "/images/sach1.jpg",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Cuộc Sống Rất Giống Cuộc Đời",
                    Author = "Hải Dở",
                    Price = 61000,
                    Description = "Đàn ông tuổi 15 mơ ước thành đàn ông tuổi 20, đàn ông tuổi 20 mơ ước thành đàn ông tuổi 30, đàn ông tuổi 30 mơ ước được trở thành đàn ông tuổi 40 và đàn ông tuổi 40 lại mơ ước đặt chân lên cổ máy thời gian để quay lại tuổi 30 với toàn bộ tài sản của mình! Vậy đấy!",
                    Image = "/images/cuoc-song-rat-giong-cuoc.jpg",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 3,
                    Title = "Lập trình C#",
                    Author = "TS. Lê Xuân Việt",
                    Price = 120000,
                    Description = "Sách học lập trình C# từ cơ bản đến nâng cao, bao gồm các kiến thức về biến, kiểu dữ liệu, cấu trúc điều khiển, lớp, đối tượng, kế thừa, đa hình, và các tính năng mới của C#.",
                    Image = "/images/bia_ky_thuat_lap_trinh_c_14.jpg",
                    CategoryId = 2
                },
                new Book
                {
                    Id = 4,
                    Title = "Lập trình Web ASP.NET",
                    Author = "TS. Lê Xuân Việt",
                    Price = 150000,
                    Description = "Sách học lập trình web với ASP.NET Core, bao gồm MVC, Razor Pages, Entity Framework Core, Identity, và triển khai ứng dụng lên môi trường thực tế.",
                    Image = "/images/sach2.jpg",
                    CategoryId = 2
                }
            );
        }
    }
}
