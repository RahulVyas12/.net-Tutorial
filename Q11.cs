using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Q11
    {
        static void Main()
        {
            Console.WriteLine("Name:");
            String name = Console.ReadLine();

            Console.WriteLine("Gender:");
            String gender = Console.ReadLine();

            if (gender == "M")
            {
                name = "Mr. " + name;
                Console.WriteLine("Name: " + name);
            }

            else if (gender == "F")
            {
                name = "Ms. " + name;
                Console.WriteLine("Name: " + name);
            }
            else
            {
                Console.Write("Invalid input");
            }
        }
    }
}
