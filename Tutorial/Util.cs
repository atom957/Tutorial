using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Util
    {
        public void printTable(int n)
        {
            for (int i = 1; i <= n; i++) // petla po wierszach
            {
                for (int t = 1; t <= n; t++) // petla po kolumnach
                {
                    Console.Write(i * t + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
