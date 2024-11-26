using System;

class Calculator
{
    public static int method(int n)
    {
        int difference = Math.Abs(n - 123);

        if (n > 123)
        {
            return difference * 3;
        }

        return difference;
    }

    static void Main()
    {
        Console.WriteLine("Введите целое число n:");
        int n = int.Parse(Console.ReadLine());

        int result = method(n);

        Console.WriteLine($"Результат: {result}");
    }
}
