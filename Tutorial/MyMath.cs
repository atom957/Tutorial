using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class MyMath
    {
        // git status, clone, add, commit, push, fetch, pull

        /**
         * Metoda do obliczania potegi liczby a do n
         */
        public int power(int a, int n)
        {
            int c = a;
            for (int i = 0; i != n; i++)
            {
                c = c * a;
            }
            return c;
        }

        /**
         * NWD liczb a i b
         */
        public int nwd(int a, int b)
        {
            int rest = a % b; // modulo czyli reszta z dzielenia 3 % 2 -> 1
            Console.WriteLine(a + ":" + b + "=" + a / b + " reszty " + a % b);
            while (rest != 0)
            {

                a = b;
                b = rest;
                Console.WriteLine(a + ":" + b + "=" + a / b + " reszty " + a % b);
                rest = a % b;
            }
            return a / b;
        }

        /**
         * Silnia z liczby a
         */
        public int factorial(int a)
        {
            int e = 1;
            for (int i = 1; i <= a; i++)
            {
                e = i * e;
            }
            return e;
        }

        /**
         * Liczby parzyste z przedzialu domknietego <a, b>
         */
        public void evenNumbers(int a, int b)
        {

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public bool isPrime(int a)
        {

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void multiple(int number, int max)
        {
            for (int i = 0; i <= max; i += number)
            {
                Console.WriteLine(i);
            }
        }

        // 3, 9 -> 9, 6, 3, 0
        // 4, 16 -> 16, 12, 8, 4, 0
        // 5, 25 -> 25, 20, 15, 10, 5, 0
        // 12, 24 -> 24, 12, 0
        public void multipleBackward(int number, int max)
        {
            for (int i = max; i >= 0; i -= number)
            {
                Console.WriteLine(i);
            }
        }

        // 3, 9 -> 0, 3, 6, 9, 6, 3, 0
        public void multipleBackwardToward(int number, int max)
        {
            bool forward = true;
            for (int i = 0; i >= 0;)
            {
                Console.WriteLine(i);
                if (i < max && forward)
                {
                    i += number;
                }
                else
                {
                    forward = false;
                    i -= number;
                }
            }

        }
        public void backWorldPrime(int number)
        {
            string a = "";
            while (number != 0)
            {
                int b = number % 10;
                a += b.ToString();
                number = number / 10;
            }
            Console.WriteLine(a);

            if (isPrime(int.Parse(a)))
            {
                Console.WriteLine("jest pierwsza liczba");
            }
            Console.WriteLine("nie jest pierwsza liczba");

        }
        public void stars1(int number)
        {
            string a = "";
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(a += '*');
            }
        }

        // n = 5
        // *   *
        // *   *
        // *   *
        // *   *
        // *   *

        // n = 3
        // * *
        // * *
        // * *

        // n = 7
        // *     *
        // *     *
        // *     *
        // *     *
        // *     *
        // *     *

        // *     *
        public void stars2(int number)
        {
            string c = "*";
            for (int a = 0; a < number - 2; a++)
            {
                c += " ";
            }
            c += '*';
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        public void stars3(int number)
        {
            string a = "";
            int b = 0;
            for (int i = 0; i < number; i++)
            {
                a += '*';
            }
            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(a.Substring(0, number - b));
                b += 1;
            }
        }
        public void stars4(int number)
        {
            int a = number - 1;
            int b = 1;
            for (int i = a, j = b; i >= 0; i--, j++)
            {
                for (int z = i; z >= 0; z--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < j; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
