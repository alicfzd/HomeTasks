using AnimalTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    public class ZooCage<T, U>
     where T : Animal, new()
     where U : Food, new()
    {
        public T Animal { get; set; }
        public U Food { get; set; }

        public ZooCage(T animal, U food)
        {
            Animal = animal;
            Food = food;
        }
    }
}
