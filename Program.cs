using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int words = sentence.Split(' ').Length;
            Console.WriteLine(words);

        }
    }
}

/*
 Enter a sentence:
fjdfnsdf dfnsdjfnsdf dsfnsdfjsdfn
3

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 15500) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
 */