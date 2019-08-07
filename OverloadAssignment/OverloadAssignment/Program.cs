using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAssignment
//Overload the "==" operator so it checks if two Employee objects are equal
//by comparing their Id property.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee empId = new Employee() { Id = 4 };
            Employee empId2 = new Employee() { Id = 49};
            Employee empId3 = new Employee() { Id = 49 };

            Console.WriteLine(empId2 == empId);
            Console.WriteLine(empId3 != empId);
            Console.Read();


                  
        }
        
    }
}
