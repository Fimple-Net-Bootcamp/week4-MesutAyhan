using System.Diagnostics;

namespace week4.Entitites
{
    public class EvcilHayvan
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Tur { get; set; }
        public int KullaniciId { get; set; }
        public int SaglikDurumuId { get; set; }

        public Kullanici Kullanici { get; set; }
        public SaglikDurumu SaglikDurumu { get; set; }
        public List<Aktivite> Aktiviteler { get; set; }
        public List<Besin> Besinler { get; set; }
        public List<Egitim> Egitimler { get; set; }
        public List<SosyalEtkilesim> SosyalEtkilesimler { get; set; }
    }
}
