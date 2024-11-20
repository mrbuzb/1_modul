namespace MovieClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Movie firstMovie = new Movie()
            {
                Name = "UyquchiKelin",
                Author = "Axad Qayum",
                Status = "New",
                Genre = "Vital",
                PublishedDate = "01.01.2024",
                Price = 0,
                language = "Uzbek",
                Quality = "16K",
                Raiting = 0,
                Time = "1h,59m,59s"
            };
            Movie secondMovie = new Movie()
            {
                Name = "MenKimman",
                Author = "Chin Chan xo",
                Status = "Old",
                Genre = "Funny",
                PublishedDate = "01.01.2000",
                Price = 0,
                language = "Any",
                Quality = "1080p",
                Raiting = 1,
                Time = "1h,29m,59s"
            };
            Movie thirdMovie = new Movie()
            {
                Name = "Avatar",
                Author = "Nobody Knows",
                Status = "Old",
                Genre = "Fantastic",
                PublishedDate = "01.01.2001",
                Price = 0,
                language = "English",
                Quality = "1080p",
                Raiting = 2,
                Time = "1h,49m,59s"
            };
        }
    }
}
