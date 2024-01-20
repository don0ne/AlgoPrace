using System;

public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Fib(4));
    }
}
