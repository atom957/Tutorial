using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Dog : Animal
    {

        public Dog(string race, int height, int age)
        {
            this.race = race;
            this.height = height;
            this.age = age;
        }

        public override void noise()
        {
            Console.WriteLine("hau hau");
        }

        public void noise(int a)
        {
            for(int i = 0; i < a; i++)
                Console.WriteLine("hau hau");
        }

        public void informations()
        {
            Console.WriteLine("rasa: "+ race +" waga: "+ height +"  wiek: " + age);
        }

    }
}
