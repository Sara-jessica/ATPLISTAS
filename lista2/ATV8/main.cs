using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a opção desejada (A, B ou C):");
        char opcao = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine("\nDigite o salário atual:");
        double salarioAtual = double.Parse(Console.ReadLine());
        double novoSalario = 0;

        switch (opcao)
        {
            case 'A':
                novoSalario = salarioAtual * 1.08;
                break;
            case 'B':
                novoSalario = salarioAtual * 1.11;
                break;
            case 'C':
                novoSalario = salarioAtual <= 1000 ? salarioAtual + 350 : salarioAtual + 200;
                break;
            default:
                Console.WriteLine("\nOpção inválida.");
                return;
        }

        Console.WriteLine("\nNovo salário: R$ " + novoSalario.ToString("F2"));
    }
}
