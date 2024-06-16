using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Declarar e preencher a matriz 4x4
                int[,] matriz = new int[4, 4];
                PreencherMatriz(matriz);

                // Calcular a soma dos elementos abaixo da diagonal principal
                int somaAbaixoDiagonal = SomarAbaixoDiagonalPrincipal(matriz);

                // Exibir os elementos da diagonal principal
                Console.WriteLine("Elementos da diagonal principal:");
                MostrarDiagonalPrincipal(matriz);

                // Exibir a soma dos elementos abaixo da diagonal principal
                Console.WriteLine($"Soma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                // Pausar para permitir a visualização dos resultados
                Console.WriteLine("Pressione qualquer tecla para fechar...");
                Console.ReadKey();
            }
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

        static int SomarAbaixoDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }

        static void MostrarDiagonalPrincipal(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine(matriz[i, i]);
            }
        }
    }
}