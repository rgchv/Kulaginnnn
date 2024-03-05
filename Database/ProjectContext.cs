using BlazorApp12.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp12.Database;

public class ProjectContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = LocalStorage.db");
    }
    
}