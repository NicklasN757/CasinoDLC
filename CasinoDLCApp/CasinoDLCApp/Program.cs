using System;

namespace CasinoDLCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamBracketBetting();
            //Det antal coins du starter med. 
            int playerCasinoCoins = 10000;
            Console.WriteLine("Du har " + playerCasinoCoins + " Coins lige nu.");
            Console.ReadLine();


            int casinCoins = 10000;


            static void TeamBracketBetting()
            {
                int arrayCounter = 0; //Used to count arrays.

                Console.WriteLine("Hello! You have chosen to bet on Team Brackets! Please tell me how many teams are in the bracket!");
                int numberOfTeams = int.Parse(Console.ReadLine());

                string[] teamNames = new string[numberOfTeams];
                Console.WriteLine("Now! Please tell me the names of the teams!");
                while (arrayCounter < numberOfTeams)
                {
                    teamNames[arrayCounter] = Console.ReadLine();
                    arrayCounter++;
                }
                arrayCounter = 0;
                Console.WriteLine("Ty! Now, please tell me how many people are betting!");
                int numberOfPeopleBetting = int.Parse(Console.ReadLine());
            }
        }
    }
}
