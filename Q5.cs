// Imports the System namespace which holds basic classes such as Console
using System;

// Declares a namespace by the name ConsoleApplication1
namespace ConsoleApplication1
{
    // Defines a class by the name Program
    class Program
    {
        // Main method - program entry point
        static void Main(string[] args)
        {
            // Initializes integer 'n' for the input of number, and 'fact' with 1 for factorial calculation
            int n, fact = 1;

            // Asks the user to input a number
            Console.WriteLine("Enter Number :");

            // Reads the input from the user as a string
            string str = Console.ReadLine();

            // Converts the input string to an integer and saves in 'n'
            n = Convert.ToInt32(str);

            // for loop running from 1 to n
            for (int i = 1; i <= n; i++)
            {
                // Multiplies 'fact' by 'i' in each loop to compute factorial
                fact = fact * i;
            }

            // Displays the final factorial result using placeholder {0}
            Console.WriteLine("Factorial : {0}", fact);

            // Waits for the user to press a key before closing the console
            Console.Read();
        }
    }
}
