using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datetime_assignment
//Print the current date and time to the console.

//Ask the user for a number.

//Print to the console the exact time in X hours,
//X being the number the user entered in step 2.
{
    class DateTime2
    {
        public static void Main()
        {
            string userInput;
            int intVal;

            DateTime date = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            //Console.WriteLine("Please enter a number: ");
            //userInput = Console.ReadLine();
            //intVal = Convert.ToInt32(userInput);

            //date = date.AddHours(intVal);
            //Console.WriteLine(date);
            //Console.ReadLine();

        }
    }
}
