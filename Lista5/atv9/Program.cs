using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declarar e preencher as matrizes A e B
            int[,] matrizA = new int[4, 6];
            int[,] matrizB = new int[4, 6];

            Console.WriteLine("Preenchendo matriz A:");
            PreencherMatriz(matrizA);

            Console.WriteLine("\nPreenchendo matriz B:");
            PreencherMatriz(matrizB);

            // Calcular e exibir a matriz S (soma de A e B)
            int[,] matrizS = SomarMatrizes(matrizA, matrizB);
            Console.WriteLine("\nMatriz S (soma de A e B):");
            ExibirMatriz(matrizS);

            // Calcular e exibir a matriz D (diferença de A e B)
            int[,] matrizD = SubtrairMatrizes(matrizA, matrizB);
            Console.WriteLine("\nMatriz D (diferença de A e B):");
            ExibirMatriz(matrizD);

            // Aguardar a entrada do usuário antes de fechar o console
            Console.WriteLine("\nPressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }

        static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static int[,] SomarMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int[,] resultado = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    resultado[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            return resultado;
        }

        static int[,] SubtrairMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int[,] resultado = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    resultado[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }
            return resultado;
        }

        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}