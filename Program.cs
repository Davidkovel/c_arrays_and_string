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

            int evenCount = 0, oddCount = 0;

            List<int> uniqueNumbers = new List<int>();

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }


            Console.WriteLine("Number of even elements: " + evenCount);
            Console.WriteLine("Number of odd elements: " + oddCount);
            Console.WriteLine("Number of unique elements: " + uniqueNumbers.Count);
        }
    }
}

/*
Введіть розмір масиву:
5
Введіть значення масиву:
1
1
2
5
5
Number of even elements: 1
Number of odd elements: 4
Number of unique elements: 3

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 16096) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
 */