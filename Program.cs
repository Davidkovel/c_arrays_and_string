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

            Console.WriteLine("Write size of the first array M");
            var m = Convert.ToInt32(Console.ReadLine());
            int[] array_m1 = new int[m];

            Console.WriteLine("Enter value of the first array M");
            string[] array_from_user = Console.ReadLine().Split(' ');
            for (int i = 0; i < m; i++)
            {
                array_m1[i] = Convert.ToInt32(array_from_user[i]);
            }

            // ARRAY 2

            Console.WriteLine("Write size of the second array N");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] array_n2 = new int[n];

            Console.WriteLine("Enter value of the second array N");
            string[] array_from_user2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                array_n2[i] = Convert.ToInt32(array_from_user2[i]);
            }

            // CONQUENTANATION OF ARRAY 3

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array_m1[i] == array_n2[j])
                    {
                        set.Add(array_m1[i]);
                    }
                }
            }

            Console.WriteLine("Array 3:");
            if (set.Count == 0)
            {
                Console.WriteLine("No common elements.");
            }
            else
            {
                foreach (int i in set)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}

/*
Write size of the first array M
3
Enter value of the first array M
1 2 3
Write size of the second array N
3
Enter value of the second array N
3 4 5
Array 3:
3
C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 10632) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…


 
 */