namespace MtgDeckApi.Models {
    public class CardModel {
        public long Id { get; set; }
        public string CardName { get; set; }
        public string CardImg { get; set; }
        public string CardDescription { get; set; }
        public string ManaCost { get; set; }
    }
}
