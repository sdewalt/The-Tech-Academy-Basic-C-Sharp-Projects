using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean comparison using a while then modifying to a do while statement
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedInput = number == 95;

            do
            {
                switch (number)
                {
                    case 23:
                        Console.WriteLine("You guessed 23. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 47:
                        Console.WriteLine("You guessed 47. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 79:
                        Console.WriteLine("You guessed 79. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 95:
                        Console.WriteLine("You guessed 95. That is correct!");
                        guessedInput = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guessedInput);

            Console.Read();
        }
    }
}
