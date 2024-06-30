using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace atv5
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
                // Lê todas as linhas do arquivo em um array de strings
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                // Inicializa o contador de linhas
                int contadorLinhas = 0;

                // Percorre cada linha do arquivo
                foreach (string linha in linhas)
                {
                    // Imprime a linha atual na tela
                    Console.WriteLine(linha);
                    contadorLinhas++;
                }

                // Exibe a contagem de linhas
                Console.WriteLine($"\nO arquivo contém {contadorLinhas} linhas.");
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}

