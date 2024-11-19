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

            Console.WriteLine("Enter the number of rows (M):");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns (N):");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, cols];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int min = array[0, 0];
            int max = array[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");

        }
    }
}

/*
Enter the number of rows (M):
2
Enter the number of columns (N):
3
Enter the elements of the array:
Element [0,0]: 2
Element [0,1]: 6
Element [0,2]: 3
Element [1,0]: 47
Element [1,1]: 8
Element [1,2]: 4
Minimum value in the array: 2
Maximum value in the array: 47

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 7432) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
 
 */