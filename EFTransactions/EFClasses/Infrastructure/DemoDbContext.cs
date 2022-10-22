using EFTransactions.EFClasses.Entities;

namespace EFTransactions.EFClasses.Infrastructure;

public class DemoDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {
    }
}