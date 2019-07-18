using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int driverAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? true or false please");
            bool driverDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int driverTickets = Convert.ToInt32(Console.ReadLine());

            bool Qualified = (driverAge > 15 && driverDUI == false && driverTickets <= 3);
            Console.WriteLine("Qualified?");
            Console.Write(Qualified);
            Console.ReadLine();
        }
    }
}
