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

            double salario, mediaSalario, maiorSalario = 0;
            int numeroFilhos, totalPessoas = 0, totalFilhos = 0, totalSalarioAte100 = 0;

            Console.WriteLine("Entre com os dados dos habitantes (digite um salário negativo para encerrar):");

            salario = double.Parse(Console.ReadLine());

            while (salario >= 0)
            {
                numeroFilhos = int.Parse(Console.ReadLine());

                totalPessoas++;
                totalFilhos += numeroFilhos;
                if (salario <= 100)
                {
                    totalSalarioAte100++;
                }

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                salario = double.Parse(Console.ReadLine());
            }

            if (totalPessoas > 0)
            {
                mediaSalario = totalSalarioAte100 > 0 ? totalFilhos / (double)totalPessoas : 0;
                double percentualSalarioAte100 = (totalSalarioAte100 / (double)totalPessoas) * 100;

                Console.WriteLine($"Média do salário da população: {mediaSalario}");
                Console.WriteLine($"Média do número de filhos: {totalFilhos / (double)totalPessoas}");
                Console.WriteLine($"Maior salário: {maiorSalario}");
                Console.WriteLine($"Percentual de pessoas com salário até R$100,00: {percentualSalarioAte100}%");
            }
            else
            {
                Console.WriteLine("Nenhum dado foi inserido.");
            }
        }
    }
}
 