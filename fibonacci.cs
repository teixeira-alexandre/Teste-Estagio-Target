using System;

class FibonacciCheck
{
    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1, fibo = 0;

        while (fibo < number)
        {
            fibo = a + b;
            a = b;
            b = fibo;
        }

        return fibo == number || number == 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int number = int.Parse(Console.ReadLine());

        if (IsFibonacci(number))
            Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
    }
}
