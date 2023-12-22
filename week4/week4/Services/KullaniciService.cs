using week4.Dtos;
using week4.Entitites;
using week4.Repostories;

namespace week4.Services
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciService _repository;

        public KullaniciService(IKullaniciService repository)
        {
            _repository = repository;
        }
        public void AddKullanici(Kullanici kullanici)
        {
            using (SanalHayvanDbContext context = new SanalHayvanDbContext())
            {
                context.Kullanicis.Add(kullanici);
                context.SaveChanges();
            }
        }

        public KullaniciDto GetKullaniciById(int id)
        {
            using (SanalHayvanDbContext context = new SanalHayvanDbContext())
            {
                Kullanici kullanici =  context.Kullanicis.FirstOrDefault(k => k.Id == id);
                if (kullanici == null)
                {
                    return new KullaniciDto();
                }
                return new KullaniciDto()
                {
                    KullaniciId = kullanici.Id,
                    KullaniciAdi = kullanici.KullaniciAdi,
                    Email = kullanici.Email,
                };
            }
        }
    }
}
