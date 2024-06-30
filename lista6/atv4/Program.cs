using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace atv4
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
                // Lê todo o conteúdo do arquivo
                string conteudo = File.ReadAllText(caminhoArquivo);

                // Inicializa a contagem de caracteres 'a'
                int contadorA = 0;

                // Percorre cada caractere do conteúdo do arquivo
                foreach (char c in conteudo)
                {
                    // Verifica se o caractere é 'a' ou 'A'
                    if (c == 'a' || c == 'A')
                    {
                        contadorA++;
                    }
                }

                // Exibe a contagem de caracteres 'a'
                Console.WriteLine($"O arquivo contém {contadorA} caracteres 'a'.");
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
