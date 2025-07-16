using System;

namespace Tutorial
{

class Q14
{
    static void Main()
    {
        Console.Write("INPUT : ");
        string number = Console.ReadLine();

        Console.Write("OUTPUT: ");
        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                string word = GetDigitWord(digit);
                Console.Write(word + " ");
            }
        }
    }

    static string GetDigitWord(char digit)
    {
        switch (digit)
        {
            case '0': return "Zero";
            case '1': return "One";
            case '2': return "Two";
            case '3': return "Three";
            case '4': return "Four";
            case '5': return "Five";
            case '6': return "Six";
            case '7': return "Seven";
            case '8': return "Eight";
            case '9': return "Nine";
            default: return "";
        }
    }
}
}