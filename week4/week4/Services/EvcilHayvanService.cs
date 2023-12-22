using week4.Dtos;
using week4.Entitites;
using week4.Interfaces;
using week4.Repostories;

namespace week4.Services
{
    public class EvcilHayvanService : IEvcilHayvanService
    {
        private readonly IEvcilHayvanRepository _repository;

        public EvcilHayvanService(IEvcilHayvanRepository repository)
        {
            _repository = repository;
        }

        public void AddHayvan(EvcilHayvan evcilHayvan)
        {
            using (SanalHayvanDbContext context = new SanalHayvanDbContext())
            {
                context.Add(evcilHayvan);
                context.SaveChanges();
            }
        }

        public List<EvcilHayvanDto> GetAll()
        {
            using (SanalHayvanDbContext context = new SanalHayvanDbContext())
            {
                List<EvcilHayvanDto> hayvans = context.EvcilHayvans.Select(x => new EvcilHayvanDto { EvcilHayvanId = x.Id, Isim = x.Isim, Tur = x.Tur, KullaniciId = x.KullaniciId }).ToList();

                if (hayvans == null)
                {
                    return new List<EvcilHayvanDto>();
                }
                return hayvans;

            }

        }

        public EvcilHayvanDto GetHayvanById(int id)
        {
            using (SanalHayvanDbContext context = new SanalHayvanDbContext())
            {
                EvcilHayvan hayvan = context.EvcilHayvans.FirstOrDefault(x => x.Id == id);
                if (hayvan == null)
                {
                    return new EvcilHayvanDto();
                }
                EvcilHayvanDto hayvanDto = new EvcilHayvanDto { EvcilHayvanId = hayvan.Id, Isim = hayvan.Isim, Tur = hayvan.Tur, KullaniciId = hayvan.KullaniciId };
                return hayvanDto;

            }
        }

        public void UpdateHayvan(int id, string tur, string isim)
        {
            using (SanalHayvanDbContext context = new SanalHayvanDbContext())
            {
                EvcilHayvan hayvan = context.EvcilHayvans.FirstOrDefault(x => x.Id == id);
                if (hayvan != null)
                {
                    hayvan.Tur = tur;
                    hayvan.Isim = isim;
                }
                context.SaveChanges();

            }
        }

        // Servis metotları ve işlemleri...
    }
}
