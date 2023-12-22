namespace week4.Entitites
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }

        public List<EvcilHayvan> EvcilHayvanlar { get; set; }
    }
}
