using week4.Entitites;

namespace week4.Repostories
{
    public class EvcilHayvanRepository
    {
        private readonly SanalHayvanDbContext _dbContext;

        public EvcilHayvanRepository(SanalHayvanDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Veritabanı işlemleri...
    }
}
