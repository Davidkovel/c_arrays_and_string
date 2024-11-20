using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an arithmetic expression with + and -:");
        string input = Console.ReadLine();

        try
        {
            double result = EvaluateExpression(input);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static double EvaluateExpression(string expression)
    {
        double result = 0;
        int sign = 1;
        int i = 0;

        while (i < expression.Length)
        {
            if (expression[i] == ' ')
            {
                i++;
                continue;
            }

            if (expression[i] == '+')
            {
                sign = 1;
                i++;
            }
            else if (expression[i] == '-')
            {
                sign = -1;
                i++;
            }
            else
            {
                double number = 0;
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    number = number * 10 + (expression[i] - '0');
                    i++;
                }
                result += sign * number;
            }
        }

        return result;
    }
}

/*
 Enter an arithmetic expression with + and -:
2 + 2
Result: 4

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 13864) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 */