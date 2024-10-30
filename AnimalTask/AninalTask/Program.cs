using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var wolf = new Wolf
            { 
                AvgLifeTime = 10, 
                Breed = "Gray Wolf",
                HP = 150, 
                AttackDamage = 50 
            };
            var elephant = new Elephant 
            { 
                AvgLifeTime = 60,
                Breed = "African Elephant",
                HP = 350, 
                Weight = 6000 
            };


            var meat = new Meat
            { 
                Calorie = 354, 
                MeatT = "Beef" 
            };

            var grass = new Grass 
            { 
                Calorie = 134, 
                Name = "Random Grass" 
            };


            var wolfCage = new ZooCage<Wolf, Meat>(wolf, meat);
            var elephantCage = new ZooCage<Elephant, Grass>(elephant, grass);


            
            wolf.Hunt(elephant);
            Console.WriteLine($"Filin cani hucumdan sonra : {elephant.HP}");

        }
    }
}
