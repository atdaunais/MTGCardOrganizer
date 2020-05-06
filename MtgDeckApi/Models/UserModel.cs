using System.Collections.Generic;

namespace MtgDeckApi.Models {
    public class UserModel {
        public long Id { get; set; }
        public string UserName { get; set; }
        public List<DeckModel> UserDecks { get; set; }
    }
}
