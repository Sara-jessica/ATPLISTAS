using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Declarar os vetores X e Y com 10 elementos cada um
            int[] vetorX = new int[10];
            int[] vetorY = new int[10];

            // Preencher os vetores X e Y com os valores
            Console.WriteLine("Preenchendo o vetor X:");
            PreencherVetor(vetorX);
            Console.WriteLine("Preenchendo o vetor Y:");
            PreencherVetor(vetorY);

            // Gerar um novo vetor com os elementos intercalados de X e Y
            int[] vetorIntercalado = GerarVetorIntercalado(vetorX, vetorY);

            // Exibir o conteúdo dos vetores
            Console.WriteLine("Conteúdo do vetor X:");
            ExibirVetor(vetorX);
            Console.WriteLine("Conteúdo do vetor Y:");
            ExibirVetor(vetorY);
            Console.WriteLine("Conteúdo do vetor intercalado:");
            ExibirVetor(vetorIntercalado);
        }

        static void PreencherVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int[] GerarVetorIntercalado(int[] vetorX, int[] vetorY)
        {
            int[] vetorIntercalado = new int[vetorX.Length + vetorY.Length];
            int indiceIntercalado = 0;

            for (int i = 0; i < vetorX.Length; i++)
            {
                vetorIntercalado[indiceIntercalado] = vetorX[i];
                indiceIntercalado++;
                vetorIntercalado[indiceIntercalado] = vetorY[i];
                indiceIntercalado++;
            }

            return vetorIntercalado;
        }

        static void ExibirVetor(int[] vetor)
        {
            foreach (int valor in vetor)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}