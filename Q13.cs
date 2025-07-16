using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Q13
    {
        static void Main()
        {
            int n = 10;
            int firstTerm = 0, secondTerm = 1;

            Console.WriteLine("Fibbonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(firstTerm + " ");

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}
