using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira um número
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            // Inicializa a soma dos divisores
            int somaDivisores = 0;

            // Inicializa uma string para armazenar os divisores
            string divisores = "Divisores: ";

            // Percorre todos os números de 1 até o número inserido
            for (int i = 1; i <= numero; i++)
            {
                // Verifica se i é um divisor do número
                if (numero % i == 0)
                {
                    // Adiciona i à soma dos divisores
                    somaDivisores += i;

                    // Adiciona i à lista de divisores
                    divisores += i + " ";
                }
            }

            // Imprime os divisores na tela
            Console.WriteLine(divisores);

            // Define o caminho do arquivo de saída
            string caminhoArquivo = "soma_divisores.txt";

            try
            {
                // Escreve a soma dos divisores no arquivo de texto
                File.WriteAllText(caminhoArquivo, $"Soma dos divisores: {somaDivisores}");
                Console.WriteLine($"A soma dos divisores foi salva no arquivo '{caminhoArquivo}'.");
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