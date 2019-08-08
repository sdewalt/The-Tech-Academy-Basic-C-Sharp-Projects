using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
//Make the Employee class take a generic type parameter.

//Add a property to the Employee class called "things" and have its data
//type be a generic list matching the generic type of the class.

//Instantiate an Employee object with type "string" as its generic 
//parameter. Assign a list of strings as the property value of Things.

//Instantiate an Employee object with type "int" as its generic parameter.
//Assign a list of integers as the property value of Things.

//Create a loop that prints all of the Things to the Console.

{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things1 = new Employee<string>();
            things1.things = new List<string>(){ "locker", "parking space", "computer", "desk", "chair"};

            Employee<int> things2 = new Employee<int>();
            things2.things = new List<int>(){ 5, 9, 22, 46, 61 };

            foreach (string element in things1.things)
            Console.WriteLine(element);

            foreach (int element in things2.things)
            Console.WriteLine(element);

            Console.ReadLine();
        }
        
    }
}
