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
            int positivos = 0, negativos = 0, zeros = 0;


            Console.Write("Digite a quantidade de números: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                double num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    positivos++;
                }
                else if (num < 0)
                {
                    negativos++;
                }
                else
                {
                    zeros++;
                }
            }


            int total = positivos + negativos + zeros;
            double percentPositivos = (double)positivos / total * 100;
            double percentNegativos = (double)negativos / total * 100;
            double percentZeros = (double)zeros / total * 100;


            Console.WriteLine($"Percentual de valores positivos: {percentPositivos:F2}%");
            Console.WriteLine($"Percentual de valores negativos: {percentNegativos:F2}%");
            Console.WriteLine($"Percentual de zeros: {percentZeros:F2}%");
        }
    }


}
   
