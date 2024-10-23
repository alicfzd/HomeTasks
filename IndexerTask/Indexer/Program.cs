using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();

            list.Add(1);
            list.Add(2, 3, 4);
            Console.WriteLine(list); 

            if (list.Insert(5, 2)) 
            {
                Console.WriteLine(list); 
            }

            int popped = list.Pop();
            Console.WriteLine(popped); 
            Console.WriteLine(list); 

            Console.WriteLine(list.Sum()); 
            Console.WriteLine(list.Average()); 
            Console.WriteLine(list.Contains(5)); 
            Console.WriteLine(list.IndexOf(5)); 
            Console.WriteLine(list.LastIndexOf(2)); 
        }
    }
}
