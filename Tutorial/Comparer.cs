using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Comparer
    {
        public int findMinOrMax(int[] tab, bool isMinimum)
        {
            int minMax = tab[0]; // the first person is the best singer :D
            for (int i = 0; i < tab.Length; i++)
            {
                if ((isMinimum && tab[i] < minMax) 
                    || (!isMinimum && tab[i] > minMax))
                {
                    minMax = tab[i]; 
                }
            }
            return minMax;
        }
    }
}
