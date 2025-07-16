using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Q21
    {
        static void Main()
        {
            Console.Write("Input the number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int term = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= terms; i++)
            {
                term = term * 10 + digit;
                Console.Write(term);
                if (i < terms) Console.Write(" + ");
                sum += term;
            }
            Console.WriteLine("\nThe Sum is: " + sum);
        }
    }

}
