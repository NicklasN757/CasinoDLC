using System;

namespace CasinoDLCApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            //Det antal coins du starter med. 
            int playerCasinoCoins = 10000;
            Console.WriteLine("Du har " + playerCasinoCoins + " Coins lige nu.");
            Console.ReadLine();


=======
            int casinCoins = 10000;


            static void TeamBracketBetting()
            {
                int numberOfTeams = 0;
                Console.WriteLine("Hello! You have chosen to bet on Team Brackets! Please tell me how many teams are in the bracket!");
                numberOfTeams = int.Parse(Console.ReadLine());
                string[] teamNames = string[numberOfTeams];
            }
>>>>>>> Stashed changes
        }
    }
}
