using System;

namespace CasinoDLCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerCasinoCoins = 10000; //Coins du starter med. 
            bool isRunning = true;


            while (isRunning)
            {
                Console.WriteLine("Du har " + playerCasinoCoins + " Coins lige nu.");
                Console.WriteLine();
                Console.WriteLine("0. Lukker dette program.");
                Console.WriteLine("1. Team Bracket Betting.");
                Console.WriteLine("2. 1v1 Team Betting.");
                Console.WriteLine("3. Slot Maskine.");
                Console.WriteLine("4. Blackjack.");
                Console.WriteLine("5. Spin The Wheel.");
                Console.WriteLine();
                Console.Write("Vælg det spil du vil spille: ");
                string reply = Console.ReadLine();
                Console.Clear();

                if (reply == "0")
                {
                    Console.WriteLine("Du har valgt nummeret " + reply + " programmet vil nu lukke.......");
                    isRunning = false;
                }
                else if (reply == "1")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Team Bracket Betting\".");
                    TeamBracketBetting();
                }
                else if (reply == "2")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"1v1 Team Betting\".");
                    teamBetting();
                }
                else if (reply == "3")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Slot Maskine\".");
                    slotMachine();
                }
                else if (reply == "4")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Blackjack\".");
                }
                else if (reply == "5")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Spin The Wheel\".");
                    SpinTheWheel(playerCasinoCoins);
                }
            }

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
                    Console.Write("Player " + number + ": ");
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

            static void slotMachine()
            {
                Random RND = new Random();
                bool isRunning = true;
                int basicPay = 15;

                while (isRunning)
                {
                    Console.WriteLine("Velkommen til vores slot maskine.");
                    Console.WriteLine();
                    Console.WriteLine("0. Tilbage til menuen.");
                    Console.WriteLine("1. Low-Risk Maskine.");
                    Console.WriteLine("2. Medium-Risk Maskine.");
                    Console.WriteLine("3. High-Risk Maskine.");
                    Console.WriteLine();
                    Console.Write("Skriv hvad for en maskine du vil spille på: ");
                    string reply = Console.ReadLine();
                }
            }
        }

        static void SpinTheWheel (int coins)
        {
            // Felter i spillet.
            int ten = 10;
            int hundred = 100;
            int thousand = 1000;
            int tenThousand = 10000;
          
            int[] wheelArray = {ten,ten,ten,ten,hundred,hundred,hundred,thousand,thousand,tenThousand};
            Random randomize = new Random();

            while (coins <= 0)
            {
                Console.WriteLine("Write your bet!");
                int playerInput = int.Parse(Console.ReadLine());
                int randomNumber = randomize.Next(0, wheelArray.Length);

                Console.WriteLine(randomNumber);
                
                if (playerInput == wheelArray[randomNumber])
                {
                    if (playerInput == ten)
                    {
                        coins += 10;
                    }
                    else if (playerInput == hundred)
                    {
                        coins += 100;
                    }
                    else if (playerInput == thousand)
                    {
                        coins += 1000;
                    }
                    else if (playerInput == tenThousand)
                    {
                        coins += 10000;
                    }
                } 
                else
                {
                    coins -= 1000;
                }

            }
        }
    }
}
