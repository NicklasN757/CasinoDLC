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
                    TeamBracketBetting(playerCasinoCoins);
                }
                else if (reply == "2")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"1v1 Team Betting\".");
                    teamBetting();
                }
                else if (reply == "3")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Slot Maskine\".");
                    playerCasinoCoins = slotMachine(playerCasinoCoins);
                }
                else if (reply == "4")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Blackjack\".");
                    BlackJack(playerCasinoCoins);
                }
                else if (reply == "5")
                {
                    Console.WriteLine("Du har valgt nummer " + reply + ". Du spiller nu \"Spin The Wheel\".");
                    SpinTheWheel(playerCasinoCoins);
                }
            }

            static void TeamBracketBetting(int coins)
            {
                int arrayCounter = 0; //Used to count arrays.
                bool peopleAreDoingSomething = true; //Used in some while loops to catch errors
                int numberOfTeams = 0;

                while (peopleAreDoingSomething == true)
                {
                    Console.WriteLine("Hello! You have chosen to bet on Team Brackets! This is a protoype, so please jsut write the number 8!");

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

                bracketCalculation(numberOfTeams);
                


            }

            static void bracketCalculation(int numberOfTeams)
            {
                int arrayCounter = 0;

                Console.WriteLine("Now! Please tell me the names of the teams in order of which they fight in!");

                string[] teamNames = new string[numberOfTeams]; //creating an array that is as long as the amount of teams
                while (arrayCounter < numberOfTeams)
                {
                    teamNames[arrayCounter] = Console.ReadLine();
                    arrayCounter++;
                }
                arrayCounter = 0;

                bool doingSomething = true;
                while (doingSomething == true)
                {
                    if (numberOfTeams % 4 == 0)
                    {
                        int matches = numberOfTeams / 2;
                        int round = numberOfTeams / 4;

                        string teamOne = teamNames[arrayCounter];
                        Console.WriteLine(teamNames[arrayCounter]);
                        arrayCounter++;
                        string teamTwo = teamNames[arrayCounter];
                        Console.WriteLine(teamNames[arrayCounter]);
                        arrayCounter++;
                        Console.WriteLine("Who are you betting on winning this match?");
                        string bet = Console.ReadLine();


                        if (bet.ToLower().Contains(teamOne))
                        {

                        }
                    }
                }
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

            static int slotMachine(int coins)
            {
                bool isRunning = true;
                int basicPay = 15;
                int totalMachinesss;
                int prize;
                int risk;
                double multipler;

                static int totalPrize(int prize, int totalMachiness)
                {
                    bool isRunning = true;
                    string reply;

                    while (isRunning) {
                        Console.Write("Er du sikker på at du vil spille på " + totalMachiness + " maskiner. Det vil koste dig: " + totalMachiness * prize + " coins. (y/n): ");
                        reply = Console.ReadLine();

                        if (reply.ToLower() == "y")
                        {
                            prize *= totalMachiness;
                            isRunning = false;
                            Console.Clear();
                        }
                    }
                    return prize;
                }
                static int numberOfMachiness()
                {
                    int numberOfMachiness;
                    Console.Write("Hvor mange maskiner vil du spille på: ");
                    numberOfMachiness = int.Parse(Console.ReadLine());
                    return numberOfMachiness;
                }
                static int machineLoop(int totalCount, int prize, int risk, double multipler)
                {
                    Random RND = new Random();
                    double totalWin = 0;

                    int i = 0;
                    while(i < totalCount)
                    {
                        i += 1;
                        Console.WriteLine();
                        int number1 = RND.Next(1, (risk+1));
                        int number2 = RND.Next(1, (risk+1));
                        int number3 = RND.Next(1, (risk+1));
                        double averageNumber = (number1 + number2 + number3) / 3;

                        Console.WriteLine("<---------------------------------------------------------------------------------------->");
                        Console.WriteLine("<|-" + number1 + "-|-" + number2 + "-|-" + number3 + "-|>");
                        Console.WriteLine("<---------------------------------------------------------------------------------------->");

                        if ((averageNumber == number1) && (averageNumber == number2) && (averageNumber == number3))
                        {
                            totalWin += prize * multipler;
                            Console.WriteLine("Du vandt " + (prize * multipler) + " coins.");
                        }
                        else
                        {
                            Console.WriteLine("Du vandt ikke. Bedre held næste gang.");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Tryke \"enter\" for at gå tilbage til menuen og for at se dit relsultat.");
                    Console.ReadLine();
                    Console.Clear();
                    return Convert.ToInt32(totalWin);
                }

                while (isRunning)
                {
                    Console.WriteLine("Velkommen til vores slot maskine.");
                    Console.WriteLine();
                    Console.WriteLine("0. Tilbage til menuen.");
                    Console.WriteLine("1. Low-Risk. ("+ basicPay + ". coins)");
                    Console.WriteLine("2. Medium-Risk. ("+ basicPay*4 +". coins)");
                    Console.WriteLine("3. High-Risk. ("+ basicPay*10 +". coins)");
                    Console.WriteLine();
                    Console.Write("Skriv hvad for en maskine du vil spille på: ");
                    string reply = Console.ReadLine();

                    if (reply == "0")
                    {
                        isRunning = false;
                        Console.Clear();
                    }
                    else if (reply == "1")
                    {
                        multipler = 5;
                        risk = 3;
                        prize = basicPay;
                        totalMachinesss = numberOfMachiness();
                        coins -= totalPrize(prize, totalMachinesss);
                        Console.WriteLine("Du har nu " + coins + " coins tilbage. Held og lykke.");
                        System.Threading.Thread.Sleep(6000);
                        int wins = machineLoop(totalMachinesss, prize, risk, multipler);
                        Console.WriteLine("Du vandt en total på " + wins + " coins");
                        coins += wins;
                        Console.WriteLine("Du har nu " + coins + " coins.");
                    }
                    else if (reply == "2")
                    {
                        multipler = 12;
                        risk = 6;
                        prize = basicPay*4;
                        totalMachinesss = numberOfMachiness();
                        coins -= totalPrize(prize, totalMachinesss);
                        Console.WriteLine("Du har nu " + coins + " coins tilbage. Held og lykke.");
                        System.Threading.Thread.Sleep(6000);
                        int wins = machineLoop(totalMachinesss, prize, risk, multipler);
                        Console.WriteLine("Du vandt en total på " + wins + " coins");
                        coins += wins;
                        Console.WriteLine("Du har nu " + coins + " coins.");
                    }
                    else if (reply == "3")
                    {
                        multipler = 25;
                        risk = 9;
                        prize = basicPay * 10;
                        totalMachinesss = numberOfMachiness();
                        coins -= totalPrize(prize, totalMachinesss);
                        Console.WriteLine("Du har nu " + coins + " coins tilbage. Held og lykke.");
                        System.Threading.Thread.Sleep(6000);
                        int wins = machineLoop(totalMachinesss, prize, risk, multipler);
                        Console.WriteLine("Du vandt en total på " + wins + " coins");
                        coins += wins;
                        Console.WriteLine("Du har nu " + coins + " coins.");
                    }
                }
                return coins;
            }
            void BlackJack(int indsatCoins)
            {
                //Insert coin amount
                Console.Write("How many coins you want to bet on a game of BlackJack: ");
                indsatCoins = int.Parse(Console.ReadLine());
                if(indsatCoins > playerCasinoCoins)
                {
                    Console.WriteLine("The inserted amount of coins is invalid you only got " + playerCasinoCoins + " available.");
                    Console.Write("Insert a valid amount of coins you want to bet on a game of BlackJack: ");
                    indsatCoins = int.Parse(Console.ReadLine());
                }

                //Cards color
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Blue();
                Console.WriteLine("                                                    YOUR CARDS ARE BLUE");
                Red();
                Console.WriteLine("                                                    THE HOUSE CARDS IS RED");
                Gray();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                //Generating a random card number
                string[] array = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Es" };
                Random randomNumber = new Random();
                int husetsFørsteKort = randomNumber.Next(array.Length);
                int husetsAndetKort = randomNumber.Next(array.Length);
                Red();
                Console.WriteLine("The house got " + array[husetsFørsteKort]);
                Gray();
                int spillerensFørsteKort = randomNumber.Next(array.Length);
                int spillerensAndetKort = randomNumber.Next(array.Length);
                Blue();
                Console.WriteLine("Your cards are: " + array[spillerensFørsteKort] + " & " + array[spillerensAndetKort]);
                Gray();
                //System.Threading.Thread.Sleep(5000);
                //Console.Clear();

                //House gets Black Jack
                if (husetsFørsteKort == 12 && husetsAndetKort == 8 || husetsFørsteKort == 12 && husetsAndetKort == 9 || husetsFørsteKort == 12 && husetsAndetKort == 10 || husetsFørsteKort == 12 && husetsAndetKort == 11)
                {
                    Console.WriteLine("House got BJ");
                }
                else if (husetsAndetKort == 12 && husetsFørsteKort == 8 || husetsAndetKort == 12 && husetsFørsteKort == 9 || husetsAndetKort == 12 && husetsFørsteKort == 10 || husetsAndetKort == 12 && husetsFørsteKort == 11)
                {
                    Console.WriteLine("House got BJ");
                }

                //You get Black Jack
                if (spillerensFørsteKort == 12 && spillerensAndetKort == 8 || spillerensFørsteKort == 12 && spillerensAndetKort == 9 || spillerensFørsteKort == 12 && spillerensAndetKort == 10 || spillerensFørsteKort == 12 && spillerensAndetKort == 11)
                {
                    Console.WriteLine("You got a BJ");

                }
                else if (spillerensAndetKort == 12 && spillerensFørsteKort == 8 || spillerensAndetKort == 12 && spillerensFørsteKort == 9 || spillerensAndetKort == 12 && spillerensFørsteKort == 10 || spillerensAndetKort == 12 && spillerensFørsteKort == 11)
                {
                    Console.WriteLine("You got a BJ");
                }

                //You want to draw or stay
                Console.Write("You want another card write \"Draw\" if you don't want another card write \"Stay\": ");
                string drawOrStay = Console.ReadLine().ToLower().Trim();
                if (drawOrStay.Contains("draw"))
                {
                    int spillerensTredjeKort = randomNumber.Next(array.Length);
                    Blue();
                    Console.WriteLine("You drew a " + spillerensTredjeKort);
                    Console.WriteLine("Your cards are: " + array[spillerensFørsteKort] + " & " + array[spillerensAndetKort] + " & " + array[spillerensTredjeKort]);
                    Red();
                    Console.WriteLine("The house got " + array[husetsFørsteKort] + " & " + array[husetsAndetKort]);
                    Gray();
                }
                else
                {
                    Red();
                    Console.WriteLine("The house got " + array[husetsFørsteKort] + " & " + array[husetsAndetKort]);
                    Blue();
                    Console.WriteLine("Your cards are: " + array[spillerensFørsteKort] + " & " + array[spillerensAndetKort]);
                    Gray();
                }

                void Gray()
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                void Red()
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                void Blue()
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

            }
        }

        static void SpinTheWheel(int coins)
        {
            // Felter i spillet.
            int ten = 10;
            int hundred = 100;
            int thousand = 1000;
            int tenThousand = 10000;
          
            int[] wheelArray = {ten,ten,ten,ten,hundred,hundred,hundred,thousand,thousand,tenThousand};
            Random randomize = new Random();

            while (coins >= 0)
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
