using System;

class Program
{
    public static void Main(string[] args)
    {
        double nota;

        Console.WriteLine("Digite a nota:");
        nota = double.Parse(Console.ReadLine());

        if (nota > 10 || nota < 0)
        {
            Console.WriteLine("Nota inválida");
        }
        else if (nota >= 8)
        {
            Console.WriteLine("Ótimo");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("Bom");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Insatisfatório");
        }
    }
}
