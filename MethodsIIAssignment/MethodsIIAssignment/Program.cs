using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIIAssignment
{
    class Program
    {
        public static void Main(string[] args)
        //Create a class. In that class, create a void method that takes two integers as parameters. Have the method
        //do a math operation on the first integer and display the second integer to the screen.

        //In the Main() method of the console app, instantiate the class.

        //Call the method in the class, passing in two numbers.

        //Call the method in the class, specifying the parameters by name.
        {
            integers product = new integers();

            product.Multiply(5, 7);

            int num1 = 5; int num2 = 7;
            product.Multiply(num1, num2);
            
            Console.ReadLine();
        }
    }
}
