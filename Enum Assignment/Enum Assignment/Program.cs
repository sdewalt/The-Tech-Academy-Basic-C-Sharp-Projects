using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
//Create an enum for the days of the week.

//Prompt the user to enter the current day of the week.

//Assign the value to a variable of that enum data type you just created.

//Wrap the above statement in a try/catch block and have it print, "Please 
//enter an actual day of the week." to the console if an error occurs.
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                
                string userInput = Console.ReadLine();

                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                Console.WriteLine("You entered: " + userInput);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");

            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
