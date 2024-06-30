using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira uma frase
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Cria uma string para armazenar a frase codificada
            string fraseCodificada = "";

            // Percorre cada caractere da frase
            foreach (char c in frase)
            {
                // Verifica se o caractere é uma letra
                if (char.IsLetter(c))
                {
                    // Define o ponto de partida ('A' ou 'a')
                    char offset = char.IsUpper(c) ? 'A' : 'a';

                    // Aplica a cifra de César com um deslocamento de 3 posições
                    char codificado = (char)((c - offset + 3) % 26 + offset);

                    // Adiciona o caractere codificado à string de resultado
                    fraseCodificada += codificado;
                }
                else
                {
                    // Adiciona o caractere original se não for uma letra
                    fraseCodificada += c;
                }
            }

            // Exibe a frase codificada
            Console.WriteLine($"Frase codificada: {fraseCodificada}");
            Console.ReadKey();
        }
    }
}
