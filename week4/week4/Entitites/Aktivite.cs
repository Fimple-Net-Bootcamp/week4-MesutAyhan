namespace week4.Entitites
{
    public class Aktivite
    {
        public int Id { get; set; }
        public int EvcilHayvanId { get; set; }
        public string AktiviteAdi { get; set; }

        public EvcilHayvan EvcilHayvan { get; set; }
    }
}
