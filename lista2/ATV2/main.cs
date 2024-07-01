using System;

class Program
{
    public static void Main(string[] args)
    {
        int numero1, numero2;

        Console.WriteLine("Digite o primeiro número:");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero2 = int.Parse(Console.ReadLine());

        int resultado = numero1 + numero2;

        if (resultado >= 10)
        {
            resultado += 5;
        }
        else
        {
            resultado += 7;
        }

        Console.WriteLine("O resultado final é: " + resultado);
    }
}
