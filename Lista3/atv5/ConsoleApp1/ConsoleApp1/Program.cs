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

            Console.Write("Digite um valor inteiro e positivo para N: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("O valor de N deve ser um número inteiro e positivo.");
            }
            else
            {
                double E = CalcularE(N);
                Console.WriteLine($"O valor de E é: {E}");
            }
        }

        static double CalcularE(int N)
        {
            double E = 1.0;
            double fatorial = 1.0;

            for (int i = 1; i <= N; i++)
            {
                fatorial *= i;
                E += 1.0 / fatorial;
            }

            return E;
        }
    }


}
