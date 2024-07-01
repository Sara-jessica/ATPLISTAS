using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um símbolo:");
        char simbolo = Console.ReadKey().KeyChar;

        switch (simbolo)
        {
            case '<':
                Console.WriteLine("\nSINAL DE MENOR");
                break;
            case '>':
                Console.WriteLine("\nSINAL DE MAIOR");
                break;
            case '=':
                Console.WriteLine("\nSINAL DE IGUAL");
                break;
            default:
                Console.WriteLine("\nOUTRO SINAL");
                break;
        }
    }
}
