using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor de X:");
        double x = double.Parse(Console.ReadLine());
        double y;

        if (x < 1)
        {
            y = 1;
        }
        else if (x >= 1 && x < 2)
        {
            y = Math.Pow(x, 2);
        }
        else if (x >= 2 && x < 3)
        {
            y = Math.Pow(x, 3);
        }
        else
        {
            y = x;
        }

        Console.WriteLine("O valor de Y é: " + y);
    }
}
