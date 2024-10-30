using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    public abstract class Animal
    {
        public int AvgLifeTime { get; set; }

        public enum Gender { Male, Female }

        public string Breed { get; set; }

        public int HP { get; set; }


        public abstract void Hunt<T>(T animal) where T : Animal;

    }
}
