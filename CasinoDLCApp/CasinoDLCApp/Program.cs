﻿using System;

namespace CasinoDLCApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            TeamBracketBetting();
            //Det antal coins du starter med. 
            int playerCasinoCoins = 10000;
=======
            int playerCasinoCoins = 10000; //Coins du starter med. 
            bool isRunning = true;
>>>>>>> master

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

        static void SpinTheWheel (int coins)
        {
            // Felter i spillet.
            int 
            string[] wheelArray = {"10","10","10","10","100","100","100","1000","1000","10000","-50","-50","-500","-500", "-5000"};
            Random randomNumber = new Random();

            while (coins <= 0)
            {
                Console.WriteLine("Write your bet!");
                string playerInput = Console.ReadLine();
                

                /* -- CODE IN PROGRESS --
                 *  
                 * randomNumber.Next(0, wheelArray.Length);
                 * 
                 * switch (playerInput)
                 * {
                 *      case wheelArray[0]:
                 *          break;
                 *      default:
                 *          break;
                 * }
                */

            }
        }
    }
}
