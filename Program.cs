using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text to encrypt:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the shift value:");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(input, shift);
        Console.WriteLine($"Encrypted Text: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine($"Decrypted Text: {decryptedText}");
    }

    static string Encrypt(string text, int shift)
    {
        char[] buffer = text.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)(((letter + shift - offset) % 26) + offset);
            }

            buffer[i] = letter;
        }

        return new string(buffer);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift);
    }
}

/*
 Enter the text to encrypt:
hello world
Enter the shift value:
2
Encrypted Text: jgnnq yqtnf
Decrypted Text: hello world

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 8728) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 
 */