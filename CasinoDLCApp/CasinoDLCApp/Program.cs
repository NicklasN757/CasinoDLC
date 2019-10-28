using System;

namespace CasinoDLCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int casinCoins = 10000;
            teamBetting();
        }
        static void teamBetting()
        {
            Console.WriteLine("Ready for lose all your gold or become a God of betting");
            Console.ReadKey();
            Console.Clear();
            string redteam = "Red Team";
            string blueteam = "Blue Team";
            int Pool = 0;

            //=========================================================================================================
            Console.Write("How many people bet on Red Team: "); int numberofpeople1 = int.Parse(Console.ReadLine());
            Console.Clear();
            int o = 0;
            int number = o + 1;
            int[] goldarray = new int[numberofpeople1];
            while (o < numberofpeople1)
            {
                Console.Write("Player "+ number +": ");
                goldarray[o] = int.Parse(Console.ReadLine());
                Pool += goldarray[o];
                o++;
            }
            //=========================================================================================================
            Console.Write("How many people bet on Blue Team: "); int numberofpeople2 = int.Parse(Console.ReadLine());
            Console.Clear();
            int p = 0;
            int number2 = p + 1;
            int[] goldarray2 = new int[numberofpeople2];
            while (p < numberofpeople2)
            {
                Console.Write("Player " + number2 + ": ");
                goldarray[p] = int.Parse(Console.ReadLine());
                Pool += goldarray[p];
                o++;
            }







        }


    }


}
