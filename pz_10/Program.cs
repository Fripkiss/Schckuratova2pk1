namespace pz_10;
using System;
class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string updatedText = ""; 
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(')
            {
                insideBrackets = true; 
            else if (text[i] == ')')
                {
                    insideBrackets = false; 
            else if (!insideBrackets)
                    {
                        updatedText += text[i]; 
                    }
                    Console.WriteLine(updatedText);
                }
            }