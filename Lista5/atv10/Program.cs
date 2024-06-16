using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 10];

            PreencherMatriz(matriz);

            Console.WriteLine("\nMatriz original:");
            ExibirMatriz(matriz);

            TrocarLinhas(matriz, 2, 8);
            Console.WriteLine("\nMatriz após trocar linha 2 com linha 8:");
            ExibirMatriz(matriz);

            TrocarColunas(matriz, 4, 10);
            Console.WriteLine("\nMatriz após trocar coluna 4 com coluna 10:");
            ExibirMatriz(matriz);

            TrocarDiagonais(matriz);
            Console.WriteLine("\nMatriz após trocar diagonal principal com diagonal secundária:");
            ExibirMatriz(matriz);

            TrocarLinhaComColuna(matriz, 5, 10);
            Console.WriteLine("\nMatriz após trocar linha 5 com coluna 10:");
            ExibirMatriz(matriz);

            Console.WriteLine("\nPressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 100); // Preenche com números aleatórios de 1 a 100
                }
            }
        }

        static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int temp = matriz[linha1, j];
                matriz[linha1, j] = matriz[linha2, j];
                matriz[linha2, j] = temp;
            }
        }

        static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int temp = matriz[i, coluna1 - 1];
                matriz[i, coluna1 - 1] = matriz[i, coluna2 - 1];
                matriz[i, coluna2 - 1] = temp;
            }
        }

        static void TrocarDiagonais(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int temp = matriz[i, i];
                matriz[i, i] = matriz[i, matriz.GetLength(1) - 1 - i];
                matriz[i, matriz.GetLength(1) - 1 - i] = temp;
            }
        }

        static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int temp = matriz[i, linha - 1];
                matriz[i, linha - 1] = matriz[i, coluna - 1];
                matriz[i, coluna - 1] = temp;
            }
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