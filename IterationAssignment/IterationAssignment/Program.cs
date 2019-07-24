using System;
using System.Collections.Generic;


namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensional array of strings. Ask the user to input some text.
            //Create a loop that goes through each string in the array, adding the user's
            //text to the string. Then create a loop that prints off each string in the 
            //array on a seperate line.

            string[] cities = { "Madrid", "Rome", "Athens", "Berlin", "Paris" };
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            Console.WriteLine("Add a city in Europe that you'd like to visit to the list: ");
            string input = Console.ReadLine();
            Console.WriteLine("The city you chose is " + input);
            Console.ReadLine();

            //Create an infinite loop.

            for (int a = 0; a < 50; a--)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            //Fix the infinite loop so it will execute.

            for (int a = 0; a < 50; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue
            //iterating the loop is a "<" operator.

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Value of i is: {0}", i);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue
            //iterating the loop is a "<=" operator.

            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine("Value of i is: {0}", i);
            }
            Console.ReadLine();

            //Create a list of strings where each item in the list is unique. Ask the
            //user to select text to search for in the list. Create a loop that iterates
            //through the list and then displays the index of the array that contains
            //matching text on the screen.

            List<string> foodType = new List<string>() { "Chinese", "Italian", "Greek", "Mexican", "French", "American" };

            for (int i = 0; i < foodType.Count; i++)
            {
                Console.WriteLine(foodType[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please choose your favorite type of cuisine from the options listed:");
            string userInput = Console.ReadLine();
            Console.WriteLine(" ");

            for (int i = 0; i < foodType.Count; i++)
            {
                if (foodType[i] == userInput)
                {
                    Console.WriteLine("The cuisine you chose is in position " + i);
                }
            }
            Console.ReadLine();

            //Add code to the loop above that tells a user if they put in text that isn't in the list

            Console.WriteLine("Please choose your favorite type of cuisine:");
            string input1 = Console.ReadLine();

            List<string> foodType1 = new List<string>() { "Chinese", "Italian", "Greek", "Mexican", "French", "American" };
            bool isAnswer = false;
            for (int i = 0; i < foodType.Count; i++)
            {
                if (input == foodType[i])
                {
                    Console.WriteLine("The cuisine you chose is " + input);
                    isAnswer = true;
                }
            }
            if (isAnswer == false)
            {
                Console.WriteLine("The cuisine you chose is not an option");
            }
            Console.ReadLine();

            //Add code to the loop above that stops it from executing once a match has been found.

            Console.WriteLine("Please choose your favorite type of cuisine:");
            string input2 = Console.ReadLine();

            List<string> foodType2 = new List<string>() { "Chinese", "Italian", "Greek", "Mexican", "French", "American" };

            for (int i = 0; i < foodType.Count; i++)
            {
                if (input == foodType[i])
                {
                    break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("The cuisine you chose is " + input);
            }
            Console.ReadLine();

            //Create a list of strings that has at least two identical strings in the list. Ask the user
            //to select text to search for in the list and then displays the indices of the array that
            //contain matching text on the screen.

            List<string> carModels = new List<string>() { "Charger", "Accord", "Eclipse", "Nova", "Duster", "Accord", "Skyline" };

            for (int i = 0; i < carModels.Count; i++)
            {
                Console.WriteLine(carModels[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please choose your favorite car model from the list");
            string userInput1 = Console.ReadLine();
            Console.WriteLine(" ");

            for (int i = 0; i < carModels.Count; i++)
            {
                if (carModels[i] == userInput)
                {
                    Console.WriteLine("The car you chose is in position " + i);
                }
            }
            Console.ReadLine();

            //Add code to the loop above that tells a user if they entered text that isn't in the list.  

            Console.WriteLine("Please choose your favorite car");
            string input3 = Console.ReadLine();

            List<string> carModels1 = new List<string>() { "Charger", "Accord", "Eclipse", "Nova", "Duster", "Accord", "Skyline" };

            bool isAnswer1 = false;
            for (int i = 0; i < carModels1.Count; i++)
            {
                if (input == carModels[i])
                {
                    Console.WriteLine("The car you chose is " + input);
                    isAnswer1 = true;
                    Console.ReadLine();
                }
            }
            if (isAnswer1 == false)
            {
                Console.WriteLine("The car you chose is not an option");
            }
            Console.ReadLine();

            //Create a list of strings that has at least two identical strings. Create a foreach
            //loop that evaluates each item in the list, and displays a message showing the
            //string and whether or not it has already appeared in the list.

            List<string> stateCapitals = new List<string>();
            stateCapitals.Add("Salem");
            stateCapitals.Add("Sacramento");
            stateCapitals.Add("Boston");
            stateCapitals.Add("Salem");
            stateCapitals.Add("Olympia");
            stateCapitals.Add("Austin");
            stateCapitals.Add("Austin");
            stateCapitals.Add("Olympia");

            List<string> alreadySeenCapital = new List<string>();

            foreach (string capital in stateCapitals)
            {

                if (alreadySeenCapital.Contains(capital))
                {
                    Console.WriteLine(capital + " has already appeared in the list");

                }
                else
                {
                    Console.WriteLine(capital + " has not appeared on the list");
                    alreadySeenCapital.Add(capital);
                }
            }
            Console.ReadLine();

        }
    }
}
