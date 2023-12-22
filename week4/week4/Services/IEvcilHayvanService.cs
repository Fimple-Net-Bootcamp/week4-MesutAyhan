using week4.Dtos;
using week4.Entitites;

namespace week4.Interfaces
{
    public interface IEvcilHayvanService
    {
        void AddHayvan(EvcilHayvan evcilHayvan);
        List<EvcilHayvanDto> GetAll();
        EvcilHayvanDto GetHayvanById(int id);
        void UpdateHayvan(int id,string tur,string isim);
    }
}
