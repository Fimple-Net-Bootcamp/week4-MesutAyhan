using week4.Dtos;
using week4.Entitites;

namespace week4.Services
{
    public interface IKullaniciService
    {
        void AddKullanici(Kullanici kullanici);
        KullaniciDto GetKullaniciById(int id);
    }
}
