using System.Collections.Generic;

namespace MtgDeckApi.Models {
    public class DeckModel {
        public long Id { get; set; }
        public string DeckName { get; set; }
        public List<CardModel> CardsInDeck { get; set; }
    }
}
