using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira a quantidade de letras
            Console.WriteLine("Digite a quantidade de letras (N):");
            int quantidadeLetras = int.Parse(Console.ReadLine());

            // Inicializa uma string para armazenar as letras
            string letras = "";

            // Solicita ao usuário que insira as letras
            for (int i = 0; i < quantidadeLetras; i++)
            {
                Console.WriteLine($"Digite a letra {i + 1}:");
                letras += Console.ReadLine();
            }

            // Define o caminho do arquivo de saída
            string caminhoArquivo = "letras.txt";

            try
            {
                // Escreve as letras no arquivo de texto
                File.WriteAllText(caminhoArquivo, letras);
                Console.WriteLine($"As letras foram salvas no arquivo '{caminhoArquivo}'.");
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                Console.WriteLine("Ocorreu um erro ao salvar o arquivo: " + ex.Message);
                return;
            }

            try
            {
                // Lê todas as letras do arquivo
                string conteudoArquivo = File.ReadAllText(caminhoArquivo);

                // Inicializa o contador de vogais
                int contadorVogais = 0;

                // Define os caracteres que são considerados vogais
                char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                // Percorre cada caractere do conteúdo do arquivo
                foreach (char c in conteudoArquivo)
                {
                    // Verifica se o caractere é uma vogal
                    if (Array.IndexOf(vogais, c) >= 0)
                    {
                        contadorVogais++;
                    }
                }

                // Exibe a quantidade de vogais
                Console.WriteLine($"A quantidade de vogais é: {contadorVogais}");
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
