using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            string playAgain = "yes";
            int winsComputer = 0;
            int winsPlayer = 0;

            while (playAgain == "y" || playAgain == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose [r]ock, [p]aper or [s]cissor: ");
                Console.ResetColor();
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissor")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input. Try again...");
                    return;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"The computer choose {computerMove}");

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    winsPlayer++;
                }
                else if ((playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors) ||
                    (playerMove == Scissors && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose!");
                    winsComputer++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was a draw.");
                    winsPlayer++;
                    winsComputer++;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Type [y]es to play again or [n]o to quit: ");
                playAgain = Console.ReadLine();

                if (playAgain != "yes" && playAgain != "y" && playAgain != "no" && playAgain != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input.Try again...");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Type [y]es to play again or [n]o to quit: ");
                    playAgain = Console.ReadLine();
                }
            }

            if (winsComputer > winsPlayer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Results: You ({winsPlayer}) : PC ({winsComputer})");
            }
            else if (winsComputer < winsPlayer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Results: You ({winsPlayer}) : PC ({winsComputer})");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Results: You ({winsPlayer}) : PC ({winsComputer})");
            }
        }
    }
}
