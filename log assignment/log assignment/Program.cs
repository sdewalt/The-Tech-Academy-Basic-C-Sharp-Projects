using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace log_assignment
//Ask the user for a number.

//Log that number to a text file.

//Print the text file back to the user.
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int intVal;

            Console.WriteLine("Please enter a number: ");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);
            Console.WriteLine("intVal: " +intVal);

            string text1 = intVal.ToString();
            File.WriteAllText(@"C:\Users\Administrator\Logs\log.txt", text1);

            string text2 = File.ReadAllText(@"C:\Users\Administrator\Logs\log.txt");
            Console.WriteLine("text2: "+text2);
            Console.ReadLine();
            
        }
    }
}
