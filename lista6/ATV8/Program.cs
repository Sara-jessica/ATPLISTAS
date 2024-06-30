using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ATV8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira a quantidade de veículos e o valor do aluguel
            Console.WriteLine("Digite a quantidade de veículos:");
            int quantidadeVeiculos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do aluguel por veículo:");
            decimal valorAluguel = decimal.Parse(Console.ReadLine());

            // Calcula o faturamento mensal
            decimal faturamentoMensal = (quantidadeVeiculos * valorAluguel) / 3;

            // Calcula o faturamento anual
            decimal faturamentoAnual = faturamentoMensal * 12;

            // Calcula o valor ganho com multas no mês
            decimal valorMultaMensal = (faturamentoMensal / 10) * 0.2m;

            // Calcula o valor gasto com manutenção anual
            decimal valorManutencaoAnual = (quantidadeVeiculos * 0.02m) * 600m;

            // Exibe os resultados na tela
            Console.WriteLine($"Faturamento mensal: R$ {faturamentoMensal:F2}");
            Console.WriteLine($"Faturamento anual: R$ {faturamentoAnual:F2}");
            Console.WriteLine($"Valor ganho com multas no mês: R$ {valorMultaMensal:F2}");
            Console.WriteLine($"Valor gasto com manutenção anual: R$ {valorManutencaoAnual:F2}");

            // Grava os resultados em um arquivo de texto
            string caminhoArquivo = "resultado.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine($"Faturamento mensal: R$ {faturamentoMensal:F2}");
                    writer.WriteLine($"Faturamento anual: R$ {faturamentoAnual:F2}");
                    writer.WriteLine($"Valor ganho com multas no mês: R$ {valorMultaMensal:F2}");
                    writer.WriteLine($"Valor gasto com manutenção anual: R$ {valorManutencaoAnual:F2}");
                }
                Console.WriteLine($"Os resultados foram salvos no arquivo '{caminhoArquivo}'.");
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                Console.WriteLine("Ocorreu um erro ao salvar o arquivo: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}