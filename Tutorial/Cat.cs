using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Cat : Animal
    {
        string colour;
        public Cat(string rase, int age, int height, string colour)
        {
            this.race = rase;
            this.age = age;
            this.height = height;
            this.colour = colour;
        }

        public override void noise()
        {
            Console.WriteLine("mial");
        }
    }
}
