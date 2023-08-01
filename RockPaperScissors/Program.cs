
using System.Runtime.CompilerServices;

namespace RPA
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] Moves = new string[]
        {
            "paper", "rock", "scissors"
        };
            Console.WriteLine("What is your name?");
            var player = Console.ReadLine();
            var currentDate = DateTime.Now;
            
            Console.WriteLine($"{Environment.NewLine}Hello, {player}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine("You get 3 turns to beat the computer.");

            bool flag = true;

            while (flag)
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{Environment.NewLine}Make your move!");
                    string move = Console.ReadLine().ToLower();

                    if (move == "exit" | move == "quit")
                    {
                        break;
                    }
                    else if (Moves.Contains(move))
                    {
                       var index = rnd.Next(1,3);
                       var compMove = Moves[index];
                       Console.WriteLine($"{Environment.NewLine}{player}: {move} VS computer: {compMove}");
                       if (move == "rock" && compMove == "scissors")
                       {
                            Console.WriteLine($"{player} wins this round!");
                       }
                       else if (move == "paper" && compMove == "rock")
                       {
                            Console.WriteLine($"{player} wins this round!");
                       }
                       else if (move == "scissors" && compMove == "paper")
                       {
                            Console.WriteLine($"{player} wins this round!");
                       }
                       else if (move == compMove)
                       {
                            Console.WriteLine("It's a tie!");
                       }
                       else
                       {
                            Console.WriteLine("Computer Wins this round!");
                       }
                    }
                    else
                    {
                        Console.WriteLine("invalid move. Make another move.");
                        i--;
                    }
                }
                Console.WriteLine($"{Environment.NewLine}Leaving so soon? Y/N");
                if (Console.ReadLine().ToLower() == "n")
                {
                    Console.WriteLine($"{Environment.NewLine}Thanks for playing! Bye Bye!");
                    flag = false;
                }
                else
                {
                    Console.WriteLine($"{Environment.NewLine}Great! Lets play another 3 rounds!");
                    flag = true;
                }

            }
        }
    }
}
