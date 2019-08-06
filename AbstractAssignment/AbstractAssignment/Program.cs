using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
 //Create an absract class called Person with two properties: string
 //firstName and string lastName.

 //Give it the method SayName().

 //Create another class called Employee and have it inherit from the Person class.

 //Implement the SayName() method inside of the Employee class.

 //Inside the Main() method, instantiate an Employee object with firstName
 //"Sample" and lastName "Student". Call the SayName() method on the object.
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();
            Console.ReadLine();
        }
    }
}
