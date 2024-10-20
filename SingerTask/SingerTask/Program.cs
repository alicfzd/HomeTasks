using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer singer = new Singer("Chester", "Bennington", 41);
            Song song = new Song("In the end", "Rock", singer);

            while (true)
            {
                Console.Write("0 və 10 arası reyting daxil et (programı dayandırmaq üçün dayan yaz): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "dayan")
                    break;

                if (double.TryParse(input, out double rating) && rating >= 0 && rating <= 10)
                {
                    song.AddRating(rating);
                    Console.WriteLine("Reyting elave olundur.");
                }
                else
                {
                    Console.WriteLine("Yalnis reyting!.");
                }
            }
            Console.WriteLine($"Mugenni: {singer.Name} {singer.Surname}, Yas: {singer.Age}, Mahnı: {song.Name}");
            Console.WriteLine($"Ortalama reyting: {song.GetAverageRating()}");
        }
    }
}
