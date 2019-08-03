using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIVAssignment
//Creata a class. In that class, create a method that takes two integers as parameters. Make
//one of them optional. Have the method do a math operation and return an integer result.

//In the Main() method of the console app, instantiate the class.

//Ask the user to input two numbers, one at a time. Let them know they need not enter
//anything for the second number.

//Call the method in the class, passing in the one or two numbers entered.

//Try various combinations of numbers on the code, including having no second number.
{

    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Please enter one or two number(s), one at a time.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            string userInput2 = Console.ReadLine();

            optionalInteger objectName = new optionalInteger();
            int result;

            if (string.IsNullOrEmpty(userInput2))
            {
                
                result = objectName.Subtract(userInput1);
            }
            else
            {
                result = objectName.Subtract(userInput1, Convert.ToInt32(userInput2));
            }
            

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
