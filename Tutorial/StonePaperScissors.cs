using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class StonePaperScissors
    {
        public void printSth()
        {

            int playerScore = 0;
            int pcScore = 0;
            while (playerScore < 3 || pcScore < 3)
            {
                Console.WriteLine("Podaj wybor: ");
                int choice = int.Parse(Console.ReadLine());
                Random rand = new Random();
                int ran = rand.Next(3);
                if(choice == (int)Type.STONE && ran == (int)Type.SCISSORS || choice == (int)Type.PAPER && ran == (int)Type.STONE || choice == (int)Type.SCISSORS && ran == (int)Type.PAPER)
                {
                    Console.WriteLine("wybur komputera: " + ran);
                    playerScore += 1;
                    Console.WriteLine("wygrales" + " " + "ty: " + playerScore + " " + "komputer: " + pcScore);
                }
                else if(choice == ran)
                {
                    Console.WriteLine("wybur komputera: " + ran);
                    Console.WriteLine("remis" + " " + "ty: " + playerScore + " " + "komputer: " + pcScore);
                }
                else
                {
                    Console.WriteLine("wybur komputera: " + ran);
                    pcScore += 1;
                    Console.WriteLine("przegrałeś" + " " + "ty: " + playerScore +" " + "komputer: " + pcScore);
                }
            }
        }

        enum Type : int
        {
            STONE = 0,
            PAPER = 1,
            SCISSORS = 2
        }
    }
}
