using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week do you work?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week do you work?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(hourlyRate1 * hoursWorked1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(hourlyRate2 * hoursWorked2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = (hourlyRate1 * hoursWorked1) > (hourlyRate2 * hoursWorked2);
            Console.Write(trueOrFalse);
            Console.ReadLine();




        }
    }
}
