using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIIIAssignment
//Create a class. In that class, create a method that will take in an integer, do a math 
//operation to it and then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the one method,
//passing in an integer, such as 12, then display the result to the screen.

//Add a second method to the class, with the same name, that will take in a decimal, do
//a different math operation to it and then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the second method,
//passing in a decimal. Display the result to the screen.

//Add a third method to the class, with the same name, that will take in a string, convert
//it to an integer if possible, do a different math operation to it and then return the
//answer as an integer.

//In the Main() method of the console app, instantiate the class and call the third method,
//passing in a string that equates to an integer. Display the result to the screen.
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = 5;

            MathOperation objectName1 = new MathOperation();
            int results1 = objectName1.Subtract(20, input1);
            Console.WriteLine(results1);
            Console.ReadLine();

            int intPart = (int)3.4278;

            MathOperation objectName2 = new MathOperation();
            int results2 = objectName2.Add(15, intPart);
            Console.WriteLine(results2);
            Console.ReadLine();

            string num1 = "40";

            MathOperation objectName3 = new MathOperation();
            int num2 = Convert.ToInt32("40");
            int results3 = objectName3.Multiply(60, num2);
            
            Console.WriteLine(results3);
            Console.ReadLine();

        }
    }
}
