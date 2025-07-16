using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class @while
    {
        public static void Main(string[] args)
        {
            int num = 321;
            string[] units = { "zero", "one", "two", "three" };
            int temp = num;
            int[] digit = new int[10]; //storing the new value
            int count = 0;
            while(temp > 0)
            {
                digit[count]= temp % 10; //storing the last digit
                //321% 10=================>1
                temp = temp / 10; //removing the last digit
                count = count + 1;
            }
            Console.WriteLine("The number is: ");
            //reverse using loop

            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(units[digit[i]] + " ");
            }
        }
    }
}
