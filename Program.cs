using System;

class Program
{
    static void Main()
    {
        int n = GetNumber("Podaj liczbę n (większą lub równą 5): ", 5);
        int k = GetNumber("Podaj liczbę k (większą lub równą 5): ", 5);

        long m = CalculateExpression(n, k);

        Console.WriteLine($"Wartość wyrażenia m = (n! - k!) / k! wynosi: {m}");

        Console.ReadKey();
    }

    static long CalculateExpression(int n, int k)
    {
        long nFactorial = CalculateFactorial(n);
        long kFactorial = CalculateFactorial(k);

        long result = (nFactorial - kFactorial) / kFactorial;

        return result;
    }

    static long CalculateFactorial(int number)
    {
        long factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static int GetNumber(string message, int minValue)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number) && number >= minValue)
            {
                break;
            }
            Console.WriteLine($"Błędne dane. Podaj liczbę większą lub równą {minValue}.");
        }

        return number;
    }
}
