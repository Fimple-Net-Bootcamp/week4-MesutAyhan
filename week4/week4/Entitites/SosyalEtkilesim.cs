namespace week4.Entitites
{
    public class SosyalEtkilesim
    {
        public int Id { get; set; }
        public string Turu { get; set; }
        public List<EvcilHayvan> KatilanEvcilHayvanlar { get; set; }
    }
}
