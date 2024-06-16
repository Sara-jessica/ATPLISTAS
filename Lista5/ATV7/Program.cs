using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV7
{
    internal class Program
    {
        static void Main(string[] args)
        { // Declarar e preencher a matriz 5x5
            int[,] matriz = new int[5, 5];
            PreencherMatriz(matriz);

            // Calcular e exibir as somas solicitadas
            int somaLinha4 = SomarLinha(matriz, 4);
            int somaColuna2 = SomarColuna(matriz, 2);
            int somaDiagonalPrincipal = SomarDiagonalPrincipal(matriz);
            int somaDiagonalSecundaria = SomarDiagonalSecundaria(matriz);
            int somaTodosElementos = SomarTodosElementos(matriz);

            Console.WriteLine($"Soma da linha 4: {somaLinha4}");
            Console.WriteLine($"Soma da coluna 2: {somaColuna2}");
            Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
            Console.WriteLine($"Soma de todos os elementos: {somaTodosElementos}");

            // Aguardar a entrada do usuário antes de fechar o console
            Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }

        // Métodos de cálculo
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

        static int SomarLinha(int[,] matriz, int linha)
        {
            int soma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[linha, j];
            }
            return soma;
        }

        static int SomarColuna(int[,] matriz, int coluna)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, coluna];
            }
            return soma;
        }

        static int SomarDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, i];
            }
            return soma;
        }

        static int SomarDiagonalSecundaria(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, matriz.GetLength(1) - 1 - i];
            }
            return soma;
        }

        static int SomarTodosElementos(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }
    }
}