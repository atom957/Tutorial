using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Class1
    {
        int[] tab = { 1, 3, 4, 4 };
        int[] tab2 = { 1, 3, 4, 4, 5 };
        char[] tabchar2 = { 'a'};
        char[] tabchar = { 'a'};

        public bool sprawdzanie_3()
        {
            int suma1 = 0;
            int suma2 = 0;
            for (int i = 0; i < tabchar.Length; i++)
            {
                suma1 += tabchar[i];
            }
            for (int i = 0; i < tabchar2.Length; i++)
            {
                suma2 += tabchar2[i];
            }

            bool isPrime = true;
            for (int i = 2; i < suma1; i++)
            {
                if (suma1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return suma1 == suma2 && isPrime;
        }

        public bool sprawdzenie_2()
        {
            for(int i = 0; i < tab2.Length; i++)
            {
                bool isEqual = false;
                for(int j = 0; j < tab.Length; j++)
                {
                    if (tab2[i] == tab[j])
                    {
                        isEqual = true;
                        break;
                    } 
                }
                if (!isEqual) return false;
            }
            return true;
        }

        public bool sprawdanie()
        {
            int[] tabCheckedValues = new int[tab.Length];
            int checks = 0, r = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                bool check = true;
                for (int j = 0; j < checks; j++)
                {
                    if (tabCheckedValues[j] == tab[i])
                    {
                        check = false;
                        break;
                    }
                }

                if (!check) continue;
                else
                {
                    tabCheckedValues[checks] = tab[i];
                    checks += 1;
                }

                for (int k = 0; k < tab2.Length; k++)
                {
                    if (tab2[k] == tab[i])
                    {
                        r++; //TODO: fix :)
                    }
                }
            }

            return r == checks;
        }
    }
}
