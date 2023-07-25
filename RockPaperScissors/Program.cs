namespace RPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine("You get 3 turns to beat the computer.");
            string move = Console.ReadLine().ToLower();
            if (move == "rock" | move == "paper" | move == "scissors")
            {
                Console.WriteLine(move);
            }
            else
            {
                Console.WriteLine("invalid move");
            }
            
        }
    }
}
