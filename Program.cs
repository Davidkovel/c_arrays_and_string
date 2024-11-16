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

            Console.WriteLine("Введіть розмір масиву:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Введіть значення масиву:");

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введіть параметр:");
            int parameter = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            foreach (int number in array)
            {
                if (number < parameter)
                {
                    count++;
                }
            }

            Console.WriteLine("Кількість значень менших за " + parameter + ": " + count);
        }
    }
}

/*
Введіть розмір масиву:
5
Введіть розмір масиву:
5
Введіть значення масиву:
1
2
5
3
7
Введіть параметр:
3
Кількість значень менших за 3: 2

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 14204) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
 */