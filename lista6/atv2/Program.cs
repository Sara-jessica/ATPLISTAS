using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira uma frase
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Cria uma string para armazenar a frase sem as vogais
            string fraseSemVogais = "";

            // Define os caracteres que são considerados vogais
            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            // Percorre cada caractere da frase
            foreach (char c in frase)
            {
                // Verifica se o caractere não é uma vogal
                if (Array.IndexOf(vogais, c) == -1)
                {
                    // Adiciona o caractere à string de resultado se não for uma vogal
                    fraseSemVogais += c;
                }
            }

            // Exibe a frase sem as vogais
            Console.WriteLine($"Frase sem vogais: {fraseSemVogais}");
            Console.ReadKey();
        }
    }
}