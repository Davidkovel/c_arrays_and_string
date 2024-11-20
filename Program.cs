using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the unacceptable word:");
        string unacceptableWord = Console.ReadLine();

        string result = ReplaceUnacceptableWords(input, unacceptableWord, out int replacements);
        Console.WriteLine($"\nResult:\n{result}");
        Console.WriteLine($"\nStatistics: {replacements} replacements of the word '{unacceptableWord}'");
    }

    static string ReplaceUnacceptableWords(string text, string word, out int replacements)
    {
        replacements = 0;
        string[] separators = { " ", ".", ",", ";", ":", "!", "?" };
        string result = text;
        int wordLength = word.Length;

        foreach (string separator in separators)
        {
            string[] parts = result.Split(new string[] { separator }, StringSplitOptions.None);
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    parts[i] = new string('*', wordLength);
                    replacements++;
                }
            }
            result = string.Join(separator, parts);
        }

        return result;
    }
}

/*
Enter the text:
sleep die die op op die
Enter the unacceptable word:
die

Result:
sleep *** *** op op ***

Statistics: 3 replacements of the word 'die'

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 16084) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 */