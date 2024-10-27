using Microsoft.EntityFrameworkCore;
using TaskMvc.Models.Entities;

namespace TaskMvc.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<GenelBilgiler> GenelBilgiler { get; set; }
        public DbSet<FaturaBilgileri> FaturaBilgileri { get; set; }
        public DbSet<TeslimAdresi> TeslimAdresi { get; set; }
        public DbSet<KarsiFirmaBilgisi> KarsiFirmaBilgisi { get; set; }
        public DbSet<MalKalemBilgileri> MalKalemBilgileri { get; set; }
        public DbSet<TalepEdilenIsleticiHizmetleri> TalepEdilenIsleticiHizmetleri { get; set; }
        public DbSet<SbifBilgiFisi> SbifBilgiFisi { get; set; }
        public DbSet<Register> Registers { get; set; }

    }
}
