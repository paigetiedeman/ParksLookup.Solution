using Microsoft.EntityFrameworkCore;

namespace ParksLookup
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options) : base(options) { }

    public DbSet<Park> Parks { get; set; }
  }
}