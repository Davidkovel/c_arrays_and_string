using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random rand = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rand.Next(-100, 101);
            }
        }

        Console.WriteLine("Array:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }

        int minElement = array[0, 0];
        int maxElement = array[0, 0];
        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        int sum = 0;
        bool startSumming = false;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if ((i == minRow && j == minCol) || (i == maxRow && j == maxCol))
                {
                    if (startSumming)
                    {
                        sum += array[i, j];
                        startSumming = false;
                    }
                    else
                    {
                        startSumming = true;
                    }
                }
                else if (startSumming)
                {
                    sum += array[i, j];
                }
            }
        }

        Console.WriteLine($"\nMinimum element: {minElement} at position ({minRow}, {minCol})");
        Console.WriteLine($"Maximum element: {maxElement} at position ({maxRow}, {maxCol})");
        Console.WriteLine($"Sum of elements between min and max elements: {sum}");
    }
}

/*
 Array:
-37 -25 93 -42 -48
-29 91 -2 80 71
15 -53 -52 9 -57
4 -62 32 -69 7
33 25 22 -34 7

Minimum element: -69 at position (3, 3)
Maximum element: 93 at position (0, 2)
Sum of elements between min and max elements: -112

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 15012) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 
 */