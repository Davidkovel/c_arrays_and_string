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

            char[] array = sentence.ToCharArray().Reverse().ToArray();
            Console.WriteLine(array);

        }
    }
}

/*
Enter a sentence:
 sun cat dogs cup tea;
;aet puc sgod tac nus

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 7204) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
 */