namespace week4.Entitites
{
    public class Besin
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Miktar { get; set; }
        public int EvcilHayvanId { get; set; }

        public EvcilHayvan EvcilHayvan { get; set; }
    }
}
