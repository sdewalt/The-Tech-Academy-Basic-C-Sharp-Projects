using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    public class Employee :Person,  IQuittable
    {
        public override void SayName()
        {
           
        }
        public void Quit()
        {
            Console.WriteLine("I choose to no longer be employed at your establishment.");
        }
    }
    
}
