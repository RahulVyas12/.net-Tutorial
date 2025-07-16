using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{ 
    class Q20
    {
        static void Main()
        {
            int rows = 4;
            int num = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write(num++ + " ");
                Console.WriteLine();
            }
        }
    }

}
