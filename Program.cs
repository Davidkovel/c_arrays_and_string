using System;

class Program
{
    static void Main()
    {
        int[] A = new int[5];
        int[,] B = new int[3, 4];

        ArrayA(A);
        ArrayB(B);

        DisplayArrayA(A);
        DisplayArrayB(B);

        int maxElement = FindMaxElement(A, B);
        int minElement = FindMinElement(A, B);
        int sum = CalculateSum(A, B);
        long product = CalculateProduct(A, B);
        int sumEvenA = CalculateSumEvenA(A);
        int sumOddColumnsB = CalculateSumOddColumnsB(B);

        Console.WriteLine($"\nMaximum element: {maxElement}");
        Console.WriteLine($"Minimum element: {minElement}");
        Console.WriteLine($"Sum of all elements: {sum}");
        Console.WriteLine($"Product of all elements: {product}");
        Console.WriteLine($"Sum of even elements in array A: {sumEvenA}");
        Console.WriteLine($"Sum of odd columns in array B: {sumOddColumnsB}");
    }

    static void ArrayA(int[] A)
    {
        Console.WriteLine("Enter 5 integers for array A:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }
    }

    static void ArrayB(int[,] B)
    {
        Random rand = new Random();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = rand.Next(100);
            }
        }
    }

    static void DisplayArrayA(int[] A)
    {
        Console.WriteLine("\nArray A:");
        foreach (int num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void DisplayArrayB(int[,] B)
    {
        Console.WriteLine("\nArray B:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int FindMaxElement(int[] A, int[,] B)
    {
        int maxElement = A[0];
        foreach (int num in A)
        {
            if (num > maxElement) maxElement = num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxElement) maxElement = B[i, j];
            }
        }
        return maxElement;
    }

    static int FindMinElement(int[] A, int[,] B)
    {
        int minElement = A[0];
        foreach (int num in A)
        {
            if (num < minElement) minElement = num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < minElement) minElement = B[i, j];
            }
        }
        return minElement;
    }

    static int CalculateSum(int[] A, int[,] B)
    {
        int sum = 0;
        foreach (int num in A)
        {
            sum += num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                sum += B[i, j];
            }
        }
        return sum;
    }

    static long CalculateProduct(int[] A, int[,] B)
    {
        long product = 1;
        foreach (int num in A)
        {
            product *= num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                product *= B[i, j];
            }
        }
        return product;
    }

    static int CalculateSumEvenA(int[] A)
    {
        int sumEvenA = 0;
        foreach (int num in A)
        {
            if (num % 2 == 0) sumEvenA += num;
        }
        return sumEvenA;
    }

    static int CalculateSumOddColumnsB(int[,] B)
    {
        int sumOddColumnsB = 0;
        for (int j = 1; j < B.GetLength(1); j += 2)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                sumOddColumnsB += B[i, j];
            }
        }
        return sumOddColumnsB;
    }
}


/*
 Enter 5 integers for array A:
A[0] = 32
A[1] = 12
A[2] = 4
A[3] = 6
A[4] = 4

Array A:
32 12 4 6 4

Array B:
61 51 91 45
3 3 3 23
94 59 13 37

Maximum element: 94
Minimum element: 3
Sum of all elements: 541
Product of all elements: 3224781321090244608
Sum of even elements in array A: 58
Sum of odd columns in array B: 218

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 16116) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:
 
 */