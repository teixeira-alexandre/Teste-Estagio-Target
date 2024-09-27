using System;
// EXERCÍCIO NÚMERO 5 DO TESTE TÉCNICO
class InverterString
{
    static string Inverter(string input)
    {
        char[] chars = new char[input.Length];
        for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
        {
            chars[i] = input[j];
        }
        return new string(chars);
    }

    static void Main(string[] args)
    {
        Console.Write("Digite a string: ");
        string input = Console.ReadLine();

        string invertida = Inverter(input);

        Console.WriteLine($"String invertida: {invertida}");
    }
}


