using System;

namespace Tutorial
{
    internal class ARRAY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter value for index " + i + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nYou entered:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }
        }
    }
}
