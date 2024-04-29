using Microsoft.EntityFrameworkCore;
using Prism.Domain.Entities;

namespace Prism.Infrastructure.Persistence
{
    public class PrismDbContext : DbContext
    {
        public PrismDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SHOP-API;User Id=sa;Password=@1234;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // CATEGORIES
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Giường", Description = "Danh mục tất cả các loại giường" },
                new Category() { Id = 2, Name = "Tủ", Description = "Danh mục tất cả các loại tủ" },
                new Category() { Id = 3, Name = "Sập", Description = "Danh mục tất cả các loại sập" },
                new Category() { Id = 4, Name = "Ban Thờ", Description = "Danh mục tất cả các loại ban thờ" },
                new Category() { Id = 5, Name = "Vòng tay", Description = "Danh mục tất cả các loại vòng tay" },
                new Category() { Id = 6, Name = "Tượng gỗ", Description = "Danh mục tất cả các loại tượng gỗ" }
                );
            // PRODUCTS

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Sập trơn", Price = 30_000_000, CreatedDate = DateTime.Now, Stock = 10, CategoryId = 3, Description = "Sập trơn" },
                new Product() { Id = 2, Name = "Sập ngũ phúc", Price = 32_000_000, CreatedDate = DateTime.Now, Stock = 5, CategoryId = 3, Description = "Sập ngũ phúc" },
                new Product() { Id = 3, Name = "Sập ba bông", Price = 33_500_000, CreatedDate = DateTime.Now, Stock = 3, CategoryId = 3, Description = "Sập ba bông" },

                new Product() { Id = 4, Name = "Tủ 3 buồng 4 cánh", Price = 22_300_000, CreatedDate = DateTime.Now, Stock = 5, CategoryId = 2, Description = "Tủ 3 buồng 4 cánh" },
                new Product() { Id = 5, Name = "Tủ 2 buồng", Price = 17_500_000, CreatedDate = DateTime.Now, Stock = 2, CategoryId = 2, Description = "Tủ 2 buồng" },
                new Product() { Id = 6, Name = "Tủ chè cánh cong", Price = 16_499_000, CreatedDate = DateTime.Now, Stock = 5, CategoryId = 2, Description = "Tủ chè cánh cong" },
                new Product() { Id = 7, Name = "Tủ chè cánh thẳng", Price = 15_499_000, CreatedDate = DateTime.Now, Stock = 6, CategoryId = 2, Description = "Tủ chè cánh thẳng" },
                new Product() { Id = 8, Name = "Tủ chè khảm trai", Price = 55_500_000, CreatedDate = DateTime.Now, Stock = 2, CategoryId = 2, Description = "Tủ chè khảm trai" },

                new Product() { Id = 9, Name = "Vòng tay trầm", Price = 3_500_000, CreatedDate = DateTime.Now, Stock = 50, CategoryId = 5, Description = "Vòng tay trầm" },
                new Product() { Id = 10, Name = "Vòng tay sưa đỏ", Price = 1_200_000, CreatedDate = DateTime.Now, Stock = 25, CategoryId = 5, Description = "Vòng tay sưa đỏ" },

                new Product() { Id = 11, Name = "Tượng gỗ quan vũ", Price = 5_600_000, CreatedDate = DateTime.Now, Stock = 8, CategoryId = 6, Description = "Tượng gỗ quan vũ" },
                new Product() { Id = 12, Name = "Tượng tam đa", Price = 12_999_000, CreatedDate = DateTime.Now, Stock = 4, CategoryId = 6, Description = "Tượng tam đa" }
                );
        }
    }
}