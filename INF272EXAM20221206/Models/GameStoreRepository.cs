using System.Collections.Generic;

namespace INF272EXAM20221206.Models
    {
    public class GameStoreRepository
        {
        public static readonly List<Store> Stores = new List<Store>
        {
            new Store{Id = 1, Name = "Tshwane Branch"},
            new Store{Id = 2, Name = "Johannesburg Branch"},
            new Store{Id = 3, Name = "Lesedi Branch"},
            new Store{Id = 4, Name = "Midvaal Branch"},
            new Store{Id = 5, Name = "Ekurhuleni Branch"},
        };

        public static readonly List<Game> Games = new List<Game>
        {
            new Game{Id = 1, Title = "The Callisto Protocol"},
            new Game{Id = 2, Title = "Starfield"},
            new Game{Id = 3, Title = "High on Life"},
            new Game{Id = 4, Title = "Goat Simulator 3"},
            new Game{Id = 5, Title = "Need for Speed Unbound"},
        };

        public static readonly List<Sale> Sales = new List<Sale>
        {
            new Sale{StoreId = 1, GameId = 4},
            new Sale{StoreId = 4, GameId = 2},
            new Sale{StoreId = 2, GameId = 5},
            new Sale{StoreId = 5, GameId = 4},
            new Sale{StoreId = 3, GameId = 3},
            new Sale{StoreId = 3, GameId = 2},
            new Sale{StoreId = 1, GameId = 1},
            new Sale{StoreId = 2, GameId = 5},
            new Sale{StoreId = 3, GameId = 3},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 2, GameId = 2},
            new Sale{StoreId = 3, GameId = 1},
            new Sale{StoreId = 5, GameId = 2},
            new Sale{StoreId = 2, GameId = 3},
            new Sale{StoreId = 3, GameId = 4},
            new Sale{StoreId = 2, GameId = 2},
            new Sale{StoreId = 2, GameId = 5},
            new Sale{StoreId = 1, GameId = 1},
            new Sale{StoreId = 1, GameId = 3},
            new Sale{StoreId = 5, GameId = 1},
            new Sale{StoreId = 3, GameId = 2},
            new Sale{StoreId = 5, GameId = 4},
            new Sale{StoreId = 2, GameId = 4},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 4, GameId = 1},
            new Sale{StoreId = 4, GameId = 2},
            new Sale{StoreId = 3, GameId = 4},
            new Sale{StoreId = 2, GameId = 3},
            new Sale{StoreId = 4, GameId = 1},
            new Sale{StoreId = 4, GameId = 2},
            new Sale{StoreId = 3, GameId = 4},
            new Sale{StoreId = 2, GameId = 3},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 2, GameId = 2},
            new Sale{StoreId = 3, GameId = 1},
            new Sale{StoreId = 5, GameId = 2},
            new Sale{StoreId = 2, GameId = 3},
            new Sale{StoreId = 3, GameId = 3},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 3, GameId = 4},
            new Sale{StoreId = 2, GameId = 3},
            new Sale{StoreId = 4, GameId = 1},
            new Sale{StoreId = 4, GameId = 2},
            new Sale{StoreId = 2, GameId = 2},
            new Sale{StoreId = 3, GameId = 1},
            new Sale{StoreId = 5, GameId = 2},
            new Sale{StoreId = 2, GameId = 3},
            new Sale{StoreId = 3, GameId = 4},
            new Sale{StoreId = 2, GameId = 2},
            new Sale{StoreId = 2, GameId = 5},
            new Sale{StoreId = 1, GameId = 1},
            new Sale{StoreId = 4, GameId = 2},
            new Sale{StoreId = 2, GameId = 2},
            new Sale{StoreId = 2, GameId = 5},
            new Sale{StoreId = 1, GameId = 5},
            new Sale{StoreId = 1, GameId = 3},
            new Sale{StoreId = 5, GameId = 1},
            new Sale{StoreId = 3, GameId = 2},
            new Sale{StoreId = 5, GameId = 4},
            new Sale{StoreId = 2, GameId = 4},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 4, GameId = 1},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 4, GameId = 3},
            new Sale{StoreId = 1, GameId = 1}
        };
        }
    }