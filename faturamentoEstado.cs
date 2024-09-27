// EXERCÍCIO 4 TESTE PRÁTICO
using System;

class PercentualFaturamento
{
    static void Main(string[] args)
    {
        decimal sp = 67836.43m;
        decimal rj = 36678.66m;
        decimal mg = 29229.88m;
        decimal es = 27165.48m;
        decimal outros = 19849.53m;

        decimal total = sp + rj + mg + es + outros;

        Console.WriteLine($"Percentual SP: {sp / total * 100:F2}%");
        Console.WriteLine($"Percentual RJ: {rj / total * 100:F2}%");
        Console.WriteLine($"Percentual MG: {mg / total * 100:F2}%");
        Console.WriteLine($"Percentual ES: {es / total * 100:F2}%");
        Console.WriteLine($"Percentual Outros: {outros / total * 100:F2}%");
    }
}
