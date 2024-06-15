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

            Console.WriteLine("Insira uma sequência de números inteiros separados por espaço:");
            string[] valores = Console.ReadLine().Split(' ');


            int positivos = 0;
            int negativos = 0;
            int zeros = 0;


            foreach (var valor in valores)
            {
                int num = int.Parse(valor);


                if (num > 0)
                    positivos++;
                else if (num < 0)
                    negativos++;
                else
                    zeros++;
            }


            Console.WriteLine($"Valores positivos: {positivos}");
            Console.WriteLine($"Valores negativos: {negativos}");
            Console.WriteLine($"Zeros: {zeros}");
        }
    }
}
