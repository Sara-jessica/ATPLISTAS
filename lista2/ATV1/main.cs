using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        int numero1;
        int numero2;

        Console.WriteLine("Digite o primeiro número:");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("O maior número é: " + numero1);
        }
        else
        {
            Console.WriteLine("O maior número é: " + numero2);
        }
    }
}
