namespace GameClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game firstGame = new Game()
            {
                Name = "SubwaySurfers",
                Author = "I Dont Know",
                Status = "Old",
                Genre = "Run",
                PublishedDate = "01.01.2010",
                Price = 0,
                language = "English",
                PlayersCount = "1 bilion",
                Raiting = 4.4,
                Downloads = 100000000
            };
            Game secondGame = new Game()
            {
                Name = "KnifeHit",
                Author = "I Dont Know",
                Status = "Old",
                Genre = "sniper",
                PublishedDate = "01.01.2010",
                Price = 0,
                language = "English",
                PlayersCount = "100 million",
                Raiting = 4.3,
                Downloads = 100000000
            };
            Game thirdGame = new Game()
            {
                Name = "WalkMaster",
                Author = "I Dont Know",
                Status = "New",
                Genre = "Walk",
                PublishedDate = "01.01.2020",
                Price = 0,
                language = "English",
                PlayersCount = "10 million",
                Raiting = 4.2,
                Downloads = 10000000
            };
        }
    }
}
