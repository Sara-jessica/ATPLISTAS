using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace atv10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira o caminho do arquivo
            Console.WriteLine("Digite o caminho do arquivo de texto:");
            string caminhoArquivo = Console.ReadLine();

            try
            {
                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                // Inicializa as variáveis para cálculo
                List<double> numeros = new List<double>();
                double max = double.MinValue;
                double min = double.MaxValue;
                double soma = 0;

                // Percorre cada linha do arquivo
                foreach (string linha in linhas)
                {
                    // Tenta converter a linha para um número de ponto flutuante
                    if (double.TryParse(linha, NumberStyles.Any, CultureInfo.InvariantCulture, out double numero))
                    {
                        // Adiciona o número à lista
                        numeros.Add(numero);

                        // Atualiza os valores de max, min e soma
                        if (numero > max) max = numero;
                        if (numero < min) min = numero;
                        soma += numero;
                    }
                    else
                    {
                        Console.WriteLine($"A linha '{linha}' não é um número válido.");
                    }
                }

                // Calcula a média
                double media = numeros.Count > 0 ? soma / numeros.Count : 0;

                // Imprime os resultados na tela
                Console.WriteLine($"Valor máximo: {max}");
                Console.WriteLine($"Valor mínimo: {min}");
                Console.WriteLine($"Média: {media}");
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}