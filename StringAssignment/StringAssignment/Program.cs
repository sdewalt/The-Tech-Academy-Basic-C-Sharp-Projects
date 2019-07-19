using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert 3 strings - String.Concat method
            string fName = "John ";
            string mName = "Alfred ";
            string lName = "Smith";
            string Name = string.Concat(fName, mName, lName);
            Console.WriteLine(Name);
            Console.ReadLine();

            ////Convert a string to uppercase
            string warning = "the sun is really hot!";
            warning = warning.ToUpper();
            Console.WriteLine(warning);
            Console.ReadLine();

            // Create a StringBuilder and build a paragraph of text, one sentance at a time
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t Once upon a time in a land far, far away.");
            sb.AppendLine("Someone needed to write a paragraph using StringBuilder.");
            sb.AppendLine("They decided to do some research and find some possible solutions.");
            sb.AppendLine("Now they can write more efficiently in Visual Studio!");
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
