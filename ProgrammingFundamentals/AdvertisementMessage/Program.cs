using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new string[] 
            { 
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." 
            };

            var @event = new string[]
            { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new string[] { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                var chosenPhrase = RandomMsg(phrases, 0, phrases.Length);
                var chosenEvent = RandomMsg(@event, 0, @event.Length);
                var chosenAuthor = RandomMsg(authors, 0, authors.Length);
                var chosenCity = RandomMsg(cities, 0, cities.Length);

                Console.WriteLine($"{chosenPhrase} {chosenEvent} {authors} - {chosenCity}.");
            }
        }

        public static string RandomMsg(string[] collection, int startRange, int endRange)
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(startRange, endRange);
            return collection[index];
        }
    }
}
