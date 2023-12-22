namespace week4.Entitites
{
    public class Egitim
    {
        public int Id { get; set; }
        public int EvcilHayvanId { get; set; }
        public string Adi { get; set; }

        public EvcilHayvan EvcilHayvan { get; set; }
    }
}
