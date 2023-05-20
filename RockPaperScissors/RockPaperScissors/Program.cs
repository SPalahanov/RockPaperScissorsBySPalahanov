namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rock = "Rock";
            string paper = "Paper";
            string scissors = "Scissors";

            bool keepPlaying = true;



            while (keepPlaying)
            {
                int wins = 0;
                int loses = 0;
                int draws = 0;

                string playerMove = " ";

                while (playerMove != "end")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Choose [r]ock, [p]aper or[s]cissors: ");
                    Console.ResetColor();

                    playerMove = Console.ReadLine();

                    if (playerMove == "r" || playerMove == "rock")
                    {
                        playerMove = rock;
                    }
                    else if (playerMove == "p" || playerMove == "paper")
                    {
                        playerMove = paper;
                    }
                    else if (playerMove == "s" || playerMove == "scissors")
                    {
                        playerMove = scissors;
                    }
                    else if (playerMove != "end")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Invalid Input. Try Again...");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }

                    if (playerMove != "end")
                    {
                        Random random = new Random();
                        int computerRandomNumber = random.Next(1, 4);

                        string computerMove = " ";

                        if (computerRandomNumber == 1)
                        {
                            computerMove = rock;
                        }
                        else if (computerRandomNumber == 2)
                        {
                            computerMove = paper;
                        }
                        else if (computerRandomNumber == 3)
                        {
                            computerMove = scissors;
                        }

                        Console.WriteLine($"The Computer chose {computerMove}.");

                        if (playerMove == rock && computerMove == rock || playerMove == paper && computerMove == paper || playerMove == scissors && computerMove == scissors)
                        {
                            draws++;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Draw");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else if (playerMove == rock && computerMove == scissors || playerMove == paper && computerMove == rock || playerMove == scissors && computerMove == paper)
                        {
                            wins++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You win");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else if (playerMove == rock && computerMove == paper || playerMove == paper && computerMove == scissors || playerMove == scissors && computerMove == rock)
                        {
                            loses++;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You lose");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }

                }

                Console.WriteLine();
                Console.WriteLine($"Wins:{wins}  Loses:{loses}  Draws:{draws}");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Type [yes] to Play Again or [no] to quit: ");
                Console.ResetColor();
                Console.WriteLine();

                string input = Console.ReadLine();

                if (input == "no")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Tank you for playing!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}