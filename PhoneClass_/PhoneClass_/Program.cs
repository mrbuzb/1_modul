using RestaruantClass;

namespace PhoneClass_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone firstPhone = new Phone()
            {
                PublishedYear = 2023,
                Status = "New",
                PhoneMemory = 128,
                Ram = 4,
                Model = "Xiaomi",
                Name = "Note 11",
                Raiting = 3.5,
                Price = "200",
                CameraMP = 48,
                Document = true
            };
            
            Phone secondPhone = new Phone()
            {
                PublishedYear = 2000,
                Status = "Old",
                PhoneMemory = 0,
                Ram = 0,
                Model = "Nokia",
                Name = "1202",
                Raiting = 5,
                Price = "Infinity",
                CameraMP = 0,
                Document = false
            };

            Phone thirdPhone = new Phone()
            {
                PublishedYear = 2023,
                Status = "New",
                PhoneMemory = 256,
                Ram = 8,
                Model = "Xiaomi",
                Name = "Note 13",
                Raiting = 5,
                Price = "300",
                CameraMP = 200,
                Document = true
            };

            secondPhone.Display();

        }
    }
}
