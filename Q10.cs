using System;

namespace Tutorial
{
    class Q10
    {
        static void Main()
        {
            Console.Write("Enter Mobile Number:");
            String mobileNumber = Console.ReadLine();

            if (mobileNumber.Length >=5)
            {
                string updatedNm = mobileNumber.Substring(0, mobileNumber.Length - 5) + new string('X', 5);
                Console.WriteLine("OUTPUT:" + updatedNm);
            }
            else
            {
                Console.WriteLine("Mobile Number is Too short");
            }
        }
    }

}
