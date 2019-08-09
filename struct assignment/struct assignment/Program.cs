using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_assignment
//Create a struct called Number and give it the property "Amount" 
//and have it be of data type decimal.

//In the Main() method, create an object of data type Number and
//assign an amount to it.

//Print the amount to the console.
{
    public struct Number
    {
        
        public decimal Amount;

        public double num { get; set; }

        static void Main(string[] args)

        {
            Number num = new Number() { num = 470.00 };
            Console.WriteLine(num.num);
            Console.ReadLine();
        }
        
    }
}
