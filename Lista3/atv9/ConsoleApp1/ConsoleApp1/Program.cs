using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de L: ");
            int L = int.Parse(Console.ReadLine());

            if (L <= 0)
            {
                Console.WriteLine("O valor de L deve ser positivo.");
            }
            else
            {
                int a = 0, b = 1, soma = 0;
                Console.Write("Soma dos elementos de Fibonacci menores que L: ");
                while (a < L)
                {
                    Console.Write($"{a} ");
                    soma += a;
                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                Console.WriteLine($"\nA soma é: {soma}");
            }
        }
    }


}
    