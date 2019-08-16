using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_assignment
//1. Ask the user for his age.

//2. Display the year the user was born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if user enters zero or negative numbers.

//5. Display a general message if exception caused by anything else.
{
    class Program
    {
        public static void Main()
        {
            
            int intValue;
            
             try
            {
                Console.WriteLine("Please enter your age: ");
                intValue = Convert.ToInt32(Console.ReadLine());

                if (intValue <= 0)
                {
                    throw new AgeException();
                }
                
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - intValue;
                
                Console.WriteLine("Your birthyear is: " + birthYear);
                Console.ReadLine();
            }

            catch (AgeException)
            {
                Console.WriteLine("Age cannot be negative or zero. Please try again.");
                Console.ReadLine();
                return;
            }

            catch (Exception)
            {
                Console.WriteLine("Enter a positive number");
                Console.ReadLine();
                return;
            }
        }
    }
}
