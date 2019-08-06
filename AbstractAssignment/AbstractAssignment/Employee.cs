using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("The person's name is " + FirstName + " " + LastName);
        }
    }
}
   
