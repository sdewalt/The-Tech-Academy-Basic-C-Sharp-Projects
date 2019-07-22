using System;
using System.Collections.Generic;


namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main()
        {
            //Create an array of strings. Ask the user to select an index of the array 
            //and then display the string at the index on the screen.
            Console.WriteLine("Please select the number of your favorite sport:");
            Console.WriteLine("0 for basketball");
            Console.WriteLine("1 for soccer");
            Console.WriteLine("2 for baseball");
            Console.WriteLine("3 for football");
            Console.WriteLine("4 for hockey");

            string[] sports = new string[5];
            sports[0] = "basketball";
            sports[1] = "soccer";
            sports[2] = "baseball";
            sports[3] = "football";
            sports[4] = "hockey";

            string InitialInput = Console.ReadLine();
            int userInput = Convert.ToInt32((InitialInput));

            if (userInput >= 5)
                Console.WriteLine("That choice is not available");

            Console.WriteLine("You chose: " + sports[userInput]);
            Console.ReadLine();

            ////Create an array of integers. Ask the user to select an index of the
            ////array and then display the integer at that index on the screen.
            Console.WriteLine("Please choose your favorite number from those provided:");
            Console.WriteLine("34");
            Console.WriteLine("59");
            Console.WriteLine("86");
            Console.WriteLine("312");
            Console.WriteLine("949");

            int[] numArray = new int[] { 34, 59, 86, 312, 949 };
            int numberInput = Convert.ToInt32(Console.ReadLine());
            
            if (numberInput != "34", "59", "86", "312", "949")
            Console.WriteLine("That number is not an option");

            Console.WriteLine("You chose: ");
            Console.ReadLine();

            //Create a list of strings. Ask the user to select an index of the list
            //and then display the content at that index on the screen
            Console.WriteLine("Please choose your favorite animal from those provided");
            Console.WriteLine("dog");
            Console.WriteLine("cat");
            Console.WriteLine("bird");
            Console.WriteLine("fish");
            Console.WriteLine("turtle");

            var animals = new List<string>() { "dog", "cat", "bird", "fish", "turtle" };
            var animalInput = Convert.ToInt32(Console.ReadLine());

            if (animalInput != "dog", "cat", "bird", "fish", "turtle")
            Console.WriteLine("That animal is not an option");

            Console.WriteLine("You chose: ");
            Console.ReadLine();




        }
    }
}
