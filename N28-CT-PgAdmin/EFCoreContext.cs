using Microsoft.EntityFrameworkCore;

namespace N28_CT_PgAdmin;

public class EFCoreContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;Port=5432;UserName=postgres;Database=postgres;Password=postgres");
    public DbSet<Person> People { get; set; }
    
    /*
    public DbSet<Person> Users { get; set; }
*/
}