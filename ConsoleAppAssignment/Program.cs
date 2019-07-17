using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = (Console.ReadLine());
            int userInput = Convert.ToInt32(input);
            Console.WriteLine(userInput * 50);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string input = (Console.ReadLine());
            int userInput = Convert.ToInt32(input);
            Console.WriteLine(userInput + 25);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string input = (Console.ReadLine());
            int userInput = Convert.ToInt32(input);
            Console.WriteLine(userInput / 21.5);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string input = (Console.ReadLine());
            int userInput = Convert.ToInt32(input);
            bool trueOrFalse = (userInput > 50);
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string input = (Console.ReadLine());
            int userInput = Convert.ToInt32(input);
            Console.WriteLine(userInput % 7);
            Console.ReadLine();
        }
    }
}
