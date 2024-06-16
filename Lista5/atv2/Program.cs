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

            // Declarar o vetor para armazenar as notas dos 10 alunos
            double[] notas = new double[10];

            // Preencher o vetor com as notas dos alunos
            PreencherNotas(notas);

            // Calcular a média da turma e contar quantos alunos obtiveram nota acima da média
            CalcularMediaEContarAcimaDaMedia(notas);
        }

        static void PreencherNotas(double[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void CalcularMediaEContarAcimaDaMedia(double[] notas)
        {
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            double media = soma / notas.Length;
            int contadorAcimaDaMedia = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > media)
                {
                    contadorAcimaDaMedia++;
                }
            }

            Console.WriteLine($"A média da turma é: {media:F2}");
            Console.WriteLine($"Número de alunos com nota acima da média: {contadorAcimaDaMedia}");

            Console.ReadKey();
        }
    }
}

