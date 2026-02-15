using Microsoft.EntityFrameworkCore;
using FinanceApp.Models;

namespace FinanceApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Title = "Thực phẩm", Note = "Chi tiêu ăn uống chính", Icon = "icons/food.png" },
            new Category { Id = 2, Title = "Tiền thuê nhà", Note = "Chi phí nhà ở", Icon = "icons/rent.png" },
            new Category { Id = 3, Title = "Đồ ăn vặt", Note = "Cá viên, trà sữa...", Icon = "icons/snack.png" },
            new Category { Id = 4, Title = "Quần áo", Note = "Chi phí mua sắm quần áo", Icon = "icons/clothes.png" },
            new Category { Id = 5, Title = "Đồ gia dụng", Note = "Vật dụng trong nhà", Icon = "icons/home.png" },
            new Category { Id = 6, Title = "Ăn ngoài", Note = "Đi ăn bên ngoài", Icon = "icons/outside-food.png" }
        );
    }

}