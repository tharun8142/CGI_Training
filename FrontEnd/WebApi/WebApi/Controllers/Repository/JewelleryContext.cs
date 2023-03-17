using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers.Entities
{
    public class JewelleryContext:DbContext
    {
        public JewelleryContext() { }
        public JewelleryContext(DbContextOptions Options):base(Options) { }
        public virtual DbSet<GoldOrnament> GoldOrnament { get; set; }
        public virtual DbSet<SilverOrnament> SilverOrnament { get; set; }
    }
}
