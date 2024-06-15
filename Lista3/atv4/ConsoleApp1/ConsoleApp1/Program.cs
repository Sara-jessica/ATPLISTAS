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

            Console.Write("Digite um número natural para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Número inválido. O fatorial não pode ser calculado para números negativos.");
            }
            else
            {
                long fatorial = CalcularFatorial(num);
                Console.WriteLine($"{num}! = {fatorial}");
            }
        }

        static long CalcularFatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                long resultado = 1;
                for (int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }
        }
    }

}
   