using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Declarar o vetor para armazenar as temperaturas de outubro
            double[] temperaturas = new double[31];

            // Preencher o vetor com as temperaturas
            PreencherTemperaturas(temperaturas);

            // Calcular e imprimir a menor e a maior temperatura ocorrida
            double menorTemperatura = CalcularMenorTemperatura(temperaturas);
            double maiorTemperatura = CalcularMaiorTemperatura(temperaturas);
            Console.WriteLine($"Menor temperatura: {menorTemperatura}°C");
            Console.WriteLine($"Maior temperatura: {maiorTemperatura}°C");

            // Calcular e imprimir a temperatura média
            double temperaturaMedia = CalcularTemperaturaMedia(temperaturas);
            Console.WriteLine($"Temperatura média: {temperaturaMedia:F2}°C");

            // Calcular e imprimir o número de dias com temperatura inferior à média
            int diasAbaixoDaMedia = CalcularDiasAbaixoDaMedia(temperaturas, temperaturaMedia);
            Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoDaMedia}");
        }

        static void PreencherTemperaturas(double[] temperaturas)
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Digite a temperatura do dia {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        static double CalcularMenorTemperatura(double[] temperaturas)
        {
            double menor = temperaturas[0];
            foreach (double temp in temperaturas)
            {
                if (temp < menor)
                {
                    menor = temp;
                }
            }
            return menor;
        }

        static double CalcularMaiorTemperatura(double[] temperaturas)
        {
            double maior = temperaturas[0];
            foreach (double temp in temperaturas)
            {
                if (temp > maior)
                {
                    maior = temp;
                }
            }
            return maior;
        }

        static double CalcularTemperaturaMedia(double[] temperaturas)
        {
            double soma = 0;
            foreach (double temp in temperaturas)
            {
                soma += temp;
            }
            return soma / temperaturas.Length;
        }

        static int CalcularDiasAbaixoDaMedia(double[] temperaturas, double media)
        {
            int contador = 0;
            foreach (double temp in temperaturas)
            {
                if (temp < media)
                {
                    contador++;
                }
            }
            return contador;


        }

    }

}
