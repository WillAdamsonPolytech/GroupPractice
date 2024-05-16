using System.Diagnostics;

namespace GroupPractice
{
    internal class Program
    {
        static void Trevor()
        {
            // the variables that i have player position and computer position is the initial spot the player and computer are at 
            // dial result is the dice being rolled
            int playerPosition = 0;
            int computerPosition = 0;
            int dialResult;

            Console.WriteLine("welcome to snakes and ladders!");
            Console.WriteLine("first person to reach 100 wins!");

            while (playerPosition < 100 && computerPosition < 100)
            {
                Console.WriteLine("players turn press enter to spin the dial...");
                Console.ReadLine();
                //dial being spun
                dialResult = new Random().Next(1, 11);

                //moves player 
                playerPosition += dialResult;

                //this is the good and bad zones (landing on snake or ladder)
                if (playerPosition == 25 || playerPosition == 50 || playerPosition == 75)
                {
                    Console.WriteLine("you landed on a snake :( move down 10 spaces");
                    playerPosition -= 10;
                }
                else if (playerPosition == 30 || playerPosition == 60 || playerPosition == 90)
                {
                    Console.WriteLine("you landed on a ladder :) move up 5 spaces");
                    playerPosition += 5;
                }

                //making sure the player doesn't go beyond 100
                if (playerPosition > 100)
                    playerPosition = 100;
                Console.WriteLine($"you are now at {playerPosition} on the board!");

                // checks for winner
                if (playerPosition == 100)
                {
                    Console.WriteLine("congratulations! you reached 100 and won the game! ABSOLUTE CINEMA!!!");
                    break;
                }

                Console.WriteLine("computer's turn: press enter for computer to spin the dial...");
                Console.ReadLine();

                // dial is spinning for the computer
                dialResult = new Random().Next(1, 11);

                // moves computer
                computerPosition += dialResult;

                // this is where you find out if the computer landed on a snake or a ladder 
                if (computerPosition == 25 || computerPosition == 50 || computerPosition == 75)
                {
                    Console.WriteLine("computer landed on a snake. moving down 10 spaces.");
                    computerPosition -= 10;
                }
                else if (computerPosition == 30 || computerPosition == 60 || computerPosition == 90)
                {
                    Console.WriteLine("computer landed on a ladder. moving up 5 spaces.");
                    computerPosition += 5;
                }

                // makes sure that computerPosition does not go above 100
                if (computerPosition > 100)
                    computerPosition = 100;

                Console.WriteLine($"computer is now at position {computerPosition}.");

                // checks for winner
                if (computerPosition == 100)
                {
                    Console.WriteLine("computer reached 100 and won the game!");
                    break;
                }
            }
            Console.ReadLine();
        }

        static void Will()
        {
            int coin, headsTotal = 0, tailsTotal = 0;
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                coin = rand.Next(1, 3);
                switch (coin)
                {
                    case 1:
                        headsTotal++;

                        break;

                    case 2:
                        tailsTotal++;

                        break;

                }


            }
            Console.WriteLine($"The number of heads is {headsTotal}\nThe number of tails is {tailsTotal}");

            Console.ReadLine();

        }

        static void Trevor1()
        {
            Console.WriteLine("Hello World!");
        }

        static void Thomas()
        {
            Random rand = new Random();
            int computer = rand.Next(1, 4);
            Console.WriteLine("enter paper, scissor, rock as P, || S, || R");
            string temp = Console.ReadLine();
            char outcome = null;
            char user = Convert.ToChar(temp);
            switch (computer)
            {
                case 1:
                    Console.WriteLine("Computer used Paper");
                    outcome = 'P';
                    break;
                case 2:
                    Console.WriteLine("computer used Scissors");
                    outcome = 'S';
                    break;
                case 3:
                    Console.WriteLine("computer used Rock");
                    outcome = 'R';
                    break;
            }
            if (user == outcome) { }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Trevor();
            Will();
            Thomas();
            Trevor1();
        }
    }
}
