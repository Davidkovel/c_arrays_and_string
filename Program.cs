using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();

        string result = CapitalizeSentences(input);
        Console.WriteLine($"Result: {result}");
    }

    static string CapitalizeSentences(string text)
    {
        StringBuilder result = new StringBuilder();
        bool capitalizeNext = true;

        foreach (char c in text)
        {
            if (capitalizeNext && char.IsLetter(c))
            {
                result.Append(char.ToUpper(c));
                capitalizeNext = false;
            }
            else
            {
                result.Append(c);
            }

            if (c == '.' || c == '!' || c == '?')
            {
                capitalizeNext = true;
            }
        }

        return result.ToString();
    }
}

/*
Enter a text:
today is good
Result: Today is good

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 14164) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 */