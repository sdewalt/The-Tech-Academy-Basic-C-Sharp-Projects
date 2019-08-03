using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class. In that class, create three methods, each of which will take one integer parameter in
//and return an integer. The methods should do some math operation on the received parameter. Put this 
//class in a seperate .cs file in the application.

//In the Main() program, ask the user what number they want to do the math operations on.

//Call each method in turn, passing the user input into the method. Display the returned integer to the screen.

namespace ClassAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number you would like to be used in the equations.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            MathOperations objectName = new MathOperations();

            int result1 = objectName.Add(50, userInput);
            Console.WriteLine("The result of the addition equation is: " + result1);
            Console.ReadLine();

            int result2 = objectName.Subtract(50, userInput);
            Console.WriteLine("The result of the subtraction equation is: " + result2);
            Console.ReadLine();

            int result3 = objectName.Multiply(50, userInput);
            Console.WriteLine("The result of the multiplication equation is: " + result3);
            Console.ReadLine();
        }

    }
}
