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

            Util util = new Util();
            util.printTable(int.Parse(Console.ReadLine()));
            
            Console.ReadKey();
        }
    }
}
