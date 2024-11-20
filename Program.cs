using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

            int vowelCount = 0;

            foreach (char c in sentence)
            {
                if (Array.Exists(vowels, vowel => vowel == c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Number of vowels in the sentence: {vowelCount}");
        }
    }
}

/*
Enter a sentence:
hahaha
Number of vowels in the sentence: 3

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 12924) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

*/