using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = new int[int.Parse(Console.ReadLine())];
            //for(int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = int.Parse(Console.ReadLine());
            // }
            //Comparer comparer = new Comparer();
            //Console.WriteLine(String.Format("Min: {0}\nMax: {1}", comparer.findMinOrMax(tab, true), comparer.findMinOrMax(tab, false)));

            //Util util = new Util();
            //util.printTable(int.Parse(Console.ReadLine()));
            //MyMath myMath = new MyMath();
            ////myMath.evenNumbers(1, 10);
            ////myMath.multiple(3, 9);
            ////myMath.multipleBackwardToward(3, 9);
            ////StonePaperScissors stonePaper = new StonePaperScissors();
            ////stonePaper.printSth();
            ////myMath.backWorldPrime(144);
            ////myMath.stars1(5);
            ////myMath.stars2(5);
            ////myMath.stars4(5);
            //Dog dog = new Dog("jamnik",50,7);
            //Dog dog2 = new Dog("york", 30, 4);
            //Dog dog3 = new Dog("owczrek niemiecki", 30, 4);
            //Cat cat = new Cat("Kot egipski", 30, 5, "brown");
            //Cat cat2 = new Cat("Kot perski", 30, 5, "brown");
            //Cat cat3 = new Cat("Kot syjamski", 30, 5, "brown");
            //dog.noise(3);
            //dog.noise();
            //cat.noise();
            Class1 class1 = new Class1();

            Console.WriteLine(class1.sprawdzanie_3());

            char a = 'a';
            int a_number = a;
            Console.WriteLine(a_number);

            Console.ReadKey();
        }
    }
}
