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

            Console.WriteLine("Введіть значення масиву через пробіл:");
            string[] inputArray = Console.ReadLine().Split(' ');

            int size = inputArray.Length;
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(inputArray[i]);
            }

            Console.WriteLine("Введіть три числа послідовності через пробіл:");
            string[] inputSequence = Console.ReadLine().Split(' ');

            int num1 = Convert.ToInt32(inputSequence[0]);
            int num2 = Convert.ToInt32(inputSequence[1]);
            int num3 = Convert.ToInt32(inputSequence[2]);

            int count = 0;

            for (int i = 0; i < size - 2; i++)
            {
                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
                {
                    count++;
                }
            }

            Console.WriteLine("Кількість повторень послідовності: " + count);
        }
    }
}

/*
 Введіть значення масиву через пробіл:
7 6 5 3 4 7 6 5 8 7 6 5
Введіть три числа послідовності через пробіл:
7 6 5
Кількість повторень послідовності: 3

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 19268) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…

 
 */