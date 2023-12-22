using Microsoft.EntityFrameworkCore;

namespace week4.Entitites
{
    public class SanalHayvanDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KENOBI;Database=master;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Aktivite> Aktivites { get; set; }
        public DbSet<Besin> Besins { get; set; }
        public DbSet<Egitim> Egitims { get; set; }
        public DbSet<EvcilHayvan> EvcilHayvans { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<SaglikDurumu> SaglikDurumus { get; set; }
        public DbSet<SosyalEtkilesim> SosyalEtkilesims { get; set; }

    }
}
