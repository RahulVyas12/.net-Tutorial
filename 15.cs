using System;

class Q15
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;
        int digits = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digits);
            number /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }
}