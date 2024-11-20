using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);

        Console.WriteLine("Multiplication of Matrix 1 by 2:");
        int[,] multipliedMatrix = MultiplyMatrixByNumber(matrix1, 2);
        PrintMatrix(multipliedMatrix);

        Console.WriteLine("Addition of Matrix 1 and Matrix 2:");
        int[,] addedMatrix = AddMatrices(matrix1, matrix2);
        PrintMatrix(addedMatrix);

        Console.WriteLine("Multiplication of Matrix 1 and Matrix 2:");
        int[,] multipliedMatrices = MultiplyMatrices(matrix1, matrix2);
        PrintMatrix(multipliedMatrices);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrixByNumber(int[,] matrix, int number)
    {
        int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] * number;
            }
        }

        return result;
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}

/*
 Matrix 1:
1 2 3
4 5 6
7 8 9
Matrix 2:
9 8 7
6 5 4
3 2 1
Multiplication of Matrix 1 by 2:
2 4 6
8 10 12
14 16 18
Addition of Matrix 1 and Matrix 2:
10 10 10
10 10 10
10 10 10
Multiplication of Matrix 1 and Matrix 2:
30 24 18
84 69 54
138 114 90

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 19112) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:


 */