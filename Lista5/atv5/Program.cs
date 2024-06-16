using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sortear 3 números entre 10 e 50 e armazená-los em um vetor
            int[] numerosSorteados = SortearNumeros();

            // Exibir os números sorteados (para fins de teste)
            Console.WriteLine("Números sorteados: ");
            foreach (int numero in numerosSorteados)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            // Ler tentativas do usuário até que ele acerte um dos números sorteados
            LerTentativas(numerosSorteados);
        }

        static int[] SortearNumeros()
        {
            Random random = new Random();
            int[] numerosSorteados = new int[3];

            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                numerosSorteados[i] = random.Next(10, 51); // Sorteia um número entre 10 e 50
            }

            return numerosSorteados;
        }

        static void LerTentativas(int[] numerosSorteados)
        {
            bool acertou = false;

            while (!acertou)
            {
                Console.Write("Tente adivinhar um dos números sorteados (entre 10 e 50): ");
                int tentativa = Convert.ToInt32(Console.ReadLine());

                foreach (int numero in numerosSorteados)
                {
                    if (tentativa == numero)
                    {
                        Console.WriteLine("Parabéns! Você acertou um dos números sorteados.");
                        acertou = true;
                        break;
                    }
                }

                if (!acertou)
                {
                    Console.WriteLine("Você não acertou. Tente novamente.");

                }
                Console.ReadKey();
            }
        }
    }
}
