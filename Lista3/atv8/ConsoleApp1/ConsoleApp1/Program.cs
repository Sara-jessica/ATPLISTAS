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


            Console.Write("Digite um valor inteiro e positivo para n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("O valor de n deve ser um número inteiro e positivo.");
            }
            else
            {
                double soma = 0.0;
                for (int i = 1; i <= n; i++)
                {
                    soma += 1.0 / i;
                }

                Console.WriteLine($"A soma é: {soma}");
            }
        }
    }


}
   