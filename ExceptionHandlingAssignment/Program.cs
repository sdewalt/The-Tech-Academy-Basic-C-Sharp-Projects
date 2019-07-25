using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers. Ask the user for a number to divide
            //each number in the list by. Write a loop that takes each integer
            //in the list, divides it by the number the user entered and
            //displays the result to the screen.

            List<int> numberList = new List<int>() { 6, 18, 27, 39, 50, 84, 93 };
            Console.WriteLine("Enter a number to be used to divide into each number in the list.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            foreach (int number in numberList)
            {
                int output = number / userInput;
                Console.WriteLine(number + " divided by " + userInput + " equals " + output);
            }
            Console.ReadLine();

            //Run that code, entering in zero as the number to divide by. 
            //Note any error messages you get.

            System.DivideByZeroException: 'Attempted to divide by zero.'

            //Run the code, entering a string as the number to divide by. 
            //Note any error messages you get.

            System.FormatException: 'Input string was not in a correct format.'

            //Now put the loop in a try/catch block. Below and outside of the try/catch block, make the
            //program display a message to the display to let you know the program has emerged from the 
            //try/catch block and continued on with the program execution. In the catch block, display
            //the error message to the screen. Then try various combinations of the user input: valid
            //numbers, zero and a string. Ensure the proper error messages display on the scrren, and
            //that the code after the try/catch block gets executed.
            try
            {
                List<int> numberList1 = new List<int>() { 6, 18, 27, 39, 50, 84, 93 };
                Console.WriteLine("Enter a number to be used to divide into each number in the list.");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                foreach (int number in numberList)
                {
                    int output = number / userInput;
                    Console.WriteLine(number + " divided by " + userInput + " equals " + output);
                }
                Console.ReadLine();
               
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Do not enter zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                Console.WriteLine("The program will now continue");
            }
            Console.ReadLine();
        }
    }
}
