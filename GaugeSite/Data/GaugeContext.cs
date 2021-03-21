using Gauge.Models;
using Microsoft.EntityFrameworkCore;

namespace Gauge.Data
{
    public class GaugeContext : DbContext
    {
        public GaugeContext(DbContextOptions<GaugeContext> opt) : base(opt)
        {

        }

        public DbSet<Observation> Observations { get; set; }

        
    }
}