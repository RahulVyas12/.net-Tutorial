using System;

namespace Tutorial

{
    class Q6
    {

        static void Main(string[] args)
        {
            int a, b, c, result;
            string str; // Declare the string variable

            Console.Write("Enter Number 1: ");
            str = Console.ReadLine(); // Missing statement 1
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            str = Console.ReadLine(); // Missing statement 2
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str); // Missing statement 3

            result = Sum(a, b, c);
            Console.WriteLine("Sum : " + result); // Missing statement 4

            Console.Read();

        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}