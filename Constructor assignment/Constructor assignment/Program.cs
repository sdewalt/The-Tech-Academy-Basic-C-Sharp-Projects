using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_assignment
//1. Create a const variable.

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.
            const string busName = "Duffy's Burger Shack";
            Console.WriteLine("Welcome to {0}", busName);
            Console.ReadLine();

            //2.
            var primeNumbers = new[] { 199, 283, 383, 467, 577, 661 };

        }
    }
    public class speedTests
    {
        //3.
        public speedTests() : this(70)
        {

        }
        public speedTests(int speed)
        {

        }
    }
}
