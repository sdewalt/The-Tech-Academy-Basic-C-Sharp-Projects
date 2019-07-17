using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string inputPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(inputPage);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpInput = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpInput);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackInput = Console.ReadLine(); 
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
