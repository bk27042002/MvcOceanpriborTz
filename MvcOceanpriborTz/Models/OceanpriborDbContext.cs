using Microsoft.EntityFrameworkCore;

namespace MvcOceanpriborTz.Models
{
    public class OceanpriborDbContext : DbContext
    {
        public OceanpriborDbContext(DbContextOptions<OceanpriborDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Ship> Ships { get; set; }
    }
}
