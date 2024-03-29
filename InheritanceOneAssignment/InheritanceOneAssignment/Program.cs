﻿using Intuit.Ipp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOneAssignment
 //Create a class called Person and give it two properties, each of data type string.
 //One called FirstName, the other LastName.

//Give the class a void method called SayName() that takes no parameters and simply
//writes the person's full name to the console in the format of: "Name: [full name]".

//Create another class called Employee and have it inherit from the Person class. Give
//the Employee class a property called Id and have it be of data type int.

//Inside of the Main method, instantiate and initialize an Employee object with a first
//name of "Sample" and a last name of "Student".

//Call the superclass method SayName() on the Employee object.
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();
            Console.ReadLine();
        }
    }
}
