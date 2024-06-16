using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar o vetor X com 10 elementos
            int[] vetorX = new int[10];

            // Preencher o vetor X com os valores
            PreencherVetor(vetorX);

            // Copiar os valores negativos para um novo vetor
            int[] vetorNegativos = CopiarValoresNegativos(vetorX);

            // Exibir o conteúdo do vetor original
            Console.WriteLine("Conteúdo do vetor original:");
            ExibirVetor(vetorX);

            // Exibir o conteúdo do vetor com valores negativos
            Console.WriteLine("Conteúdo do vetor com valores negativos:");
            ExibirVetor(vetorNegativos);
        }

        static void PreencherVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int[] CopiarValoresNegativos(int[] vetor)
        {
            // Contar quantos valores negativos existem no vetor
            int contadorNegativos = 0;
            foreach (int valor in vetor)
            {
                if (valor < 0)
                {
                    contadorNegativos++;
                }
            }

            // Criar um novo vetor para armazenar os valores negativos
            int[] vetorNegativos = new int[contadorNegativos];
            int indice = 0;
            foreach (int valor in vetor)
            {
                if (valor < 0)
                {
                    vetorNegativos[indice] = valor;
                    indice++;
                }
            }

            return vetorNegativos;
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

