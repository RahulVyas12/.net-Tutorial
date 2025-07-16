using System;


namespace Tutorial
{ 
class Q9
{
    static void Main()
    {
        Console.Write("INPUT : ");
        string input = Console.ReadLine();

        string toggleCase = ConvertToToggleCase(input);

        Console.WriteLine("OUTPUT: " + toggleCase);
    }

    static string ConvertToToggleCase(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsUpper(characters[i]))
            {
                characters[i] = char.ToLower(characters[i]);
            }
            else if (char.IsLower(characters[i]))
            {
                characters[i] = char.ToUpper(characters[i]);
            }
        
        }

        return new string(characters);
    }
}
}