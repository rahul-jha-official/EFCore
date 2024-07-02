using Demo.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=RAHUL;Database=EFDemo;TrustServerCertificate=True;Trusted_Connection=True;");
    }
}
