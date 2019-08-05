using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisionMethodAssignment
//Create a class. In that class, create a void method that outputs an integer. Have
//the method divide the data passed in by 2.

//In the Main() method, instantiate that class.

//Have the user enter a number. Call the method on that number. Display the output
//to the screen. It should be the entered number, divided by two.

//Create a method with output parameters.

//Overload a method.

//Declare a class to be static.
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number you'd like to be used in the equation.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            divideBy2 objectName = new divideBy2();
            objectName.Divide(2);
            Console.WriteLine(objectName.Divide(userInput));
            Console.WriteLine();
            objectName.Multiplication(2, 34.5f, 5);

            Console.ReadLine();

        }

    }
}

