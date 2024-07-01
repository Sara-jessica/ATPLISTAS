using System;

class Program
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Digite o coeficiente 'a' da equação:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente 'b' da equação:");
        b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Não é uma equação do primeiro grau válida (a não pode ser zero).");
        }
        else
        {
            double raiz = -b / a;
            Console.WriteLine("A raiz da equação é: " + raiz);
        }
    }
}
