using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_assignment
//1. In the Main() method, create a list of at least 10 employees. Each employee
//should have a first and last name, as well as an Id. At least two employees
//should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".

//3. Do the same thing again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of employees with an Id number greater than 5.
{
    public class program {  
        
        public static void Main(string[] args)
        {
            //1.
            List<Employees> employeeList = new List<Employees>();
            employeeList.Add(new Employees() { fName = "Ty", lName = "Cobb", Id = 4 });
            employeeList.Add(new Employees() { fName = "Cy", lName = "Young", Id = 2 });
            employeeList.Add(new Employees() { fName = "Joe", lName = "Tinker", Id = 1 });
            employeeList.Add(new Employees() { fName = "Herb", lName = "Pennock", Id = 14 });
            employeeList.Add(new Employees() { fName = "Mel", lName = "Ott", Id = 7 });
            employeeList.Add(new Employees() { fName = "Joe", lName = "DiMaggio", Id = 22 });
            employeeList.Add(new Employees() { fName = "Willie", lName = "Mays", Id = 9 });
            employeeList.Add(new Employees() { fName = "Nolan", lName = "Ryan", Id = 11 });
            employeeList.Add(new Employees() { fName = "Wade", lName = "Boggs", Id = 16 });
            employeeList.Add(new Employees() { fName = "Joe", lName = "Cronin", Id = 34 });
            employeeList.Add(new Employees() { fName = "Jeff", lName = "Bagwell", Id = 27 });
            employeeList.Add(new Employees() { fName = "Joe", lName = "Sewall", Id = 24 });

            //2.
            foreach (var emp in employeeList)
            {
                if (emp.fName == "Joe")
                {
                    Console.WriteLine(emp.fName + " " + emp.lName);
                }
            }
            Console.ReadLine();

            //3.
            var emp1 = employeeList.Where(x => x.fName == "Joe");
            foreach (var emp in employeeList)
            {
                if (emp.fName == "Joe")
                {
                    Console.WriteLine(emp.fName + " " + emp.lName);
                }
            }
            Console.ReadLine();

            //4.
            var emp2 = employeeList.Where(x => x.Id > 5);
            foreach (var emp in employeeList)
            {
                if (emp.Id > 5)
                {
                    Console.WriteLine(emp.fName + " " + emp.lName);
                }
            }
            Console.ReadLine();

        }
    }
}
