using Microsoft.EntityFrameworkCore;

namespace DDDWebAPITemplate.Infrastructure.Database.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}