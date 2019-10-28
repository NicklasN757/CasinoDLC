using System;

namespace CasinoDLCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerCasinoCoins = 10000; //Coins du starter med. 
            bool isRunning = true;

            while (isRunning) { 
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
                }
                else if (reply == "3")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Slot Maskine\".");
                }
                else if (reply == "4")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Blackjack\".");
                }
                else if (reply == "5")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Spin The Wheel\".");
                }
            }

            void TeamBracketBetting()
            {
                int arrayCounter = 0; //Used to count arrays.
                bool peopleAreDoingSomething = true; //Used in some while loops to catch errors
                int numberOfTeams = 0;

                while (peopleAreDoingSomething == true)
                {
                    Console.WriteLine("Hello! You have chosen to bet on Team Brackets! Please tell me how many teams are in the bracket!");

                    try
                    {
                        numberOfTeams = int.Parse(Console.ReadLine());
                        peopleAreDoingSomething = false;
                    } 
                    catch (Exception)
                    {
                        Console.WriteLine("Hey! That's not a valid answer!");
                    }
                }

                Console.WriteLine("Now! Please tell me the names of the teams!");

                string[] teamNames = new string[numberOfTeams]; //creating an array that is as long as the amount of teams
                while (arrayCounter < numberOfTeams)
                {
                    teamNames[arrayCounter] = Console.ReadLine();
                    arrayCounter++;
                }
                arrayCounter = 0;

                int numberOfBetters = 0;
                peopleAreDoingSomething = true;
                while (peopleAreDoingSomething == true)
                {
                    Console.WriteLine("Now, please tell me how many people are betting!");

                    try
                    {
                        numberOfBetters = int.Parse(Console.ReadLine());
                        peopleAreDoingSomething = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hey! That's not a valid answer!");
                    }
                }

                int[] betterMoney = new int[numberOfBetters];
                string[] betterNames = new string[numberOfBetters];
                Console.WriteLine("Now! Please tell me the names of the betters!");
                while (arrayCounter < numberOfBetters)
                {
                    betterNames[arrayCounter] = Console.ReadLine();
                    arrayCounter++;
                }
                arrayCounter = 0;

                int[] betterBets = new int[numberOfBetters];
                while (arrayCounter < numberOfBetters)
                {
                    Console.WriteLine("Now please tell me how much money " + betterNames[arrayCounter] + " is betting");

                    try
                    {
                        betterBets[arrayCounter] = int.Parse(Console.ReadLine());
                        betterMoney[arrayCounter] = 10000 - betterBets[arrayCounter];
                        arrayCounter++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hey! That's not a valid answer!");
                    }
                }
                arrayCounter = 0;

                Console.WriteLine("The bets are in!");
                while (arrayCounter < numberOfBetters)
                {
                    Console.WriteLine(betterNames[arrayCounter] + " is betting " + betterBets[arrayCounter] + " coin, and has " + betterMoney[arrayCounter] + " coins left.");
                    arrayCounter++;
                }
                arrayCounter = 0;



            }
        }
    }
}
