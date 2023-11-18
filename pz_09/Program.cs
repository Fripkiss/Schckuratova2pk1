namespace pz_09;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            bool isOnlyLetters = true;
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    isOnlyLetters = false;
                    break;
                }
            }

            if (isOnlyLetters)
            {
                Console.WriteLine(input);
                break;
            }
        }
    }
}