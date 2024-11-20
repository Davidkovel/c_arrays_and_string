using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the main string:");
            string mainString = Console.ReadLine();

            Console.WriteLine("Enter the substring to search:");
            string substring = Console.ReadLine();

            int count = CountOccurrences(mainString, substring);

            Console.WriteLine($"The substring '{substring}' occurs {count} time(s) in the main string.");
        }

        static int CountOccurrences(string mainString, string substring)
        {
            int count = 0;
            int index = mainString.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = mainString.IndexOf(substring, index + substring.Length);
            }

            return count;
        }
    }
}

/*
Enter the main string:
Why she had to go. I don't know, she wouldn't say;
Enter the substring to search:
she
The substring 'she' occurs 2 time(s) in the main string.

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 3176) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:
*/