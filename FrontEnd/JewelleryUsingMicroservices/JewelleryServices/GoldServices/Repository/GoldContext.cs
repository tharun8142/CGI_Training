using GoldServices.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoldServices.Repository
{
    public class GoldContext:DbContext
    {
        public GoldContext()
        {

        }
        public GoldContext(DbContextOptions<GoldContext> options) : base(options) { 
        }
        public virtual DbSet<GoldOrnament> GoldOrnaments { get; set; }
    }
}
