using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaração do vetor N com 20 elementos
            int[] N = new int[20];

            // Instância da classe Random para gerar números aleatórios (opcional, para teste)
            Random random = new Random();

            // Leitura dos elementos do vetor
            for (int i = 0; i < N.Length; i++)
            {
                // Atribui um valor aleatório ao vetor (para teste, substitua com Console.ReadLine() para entrada do usuário)
                N[i] = random.Next(1, 101); // Gera números aleatórios entre 1 e 100

                // Exibe o valor atribuído (opcional, para visualização)
                Console.WriteLine($"N[{i}] = {N[i]}");
            }

            // Variável para armazenar o menor valor encontrado, inicializado com o primeiro elemento do vetor
            int menorValor = N[0];

            // Variável para armazenar a posição do menor valor, inicializada como 0
            int posicaoMenor = 0;

            // Iteração pelo vetor para encontrar o menor valor e sua posição
            for (int i = 1; i < N.Length; i++)
            {
                // Verifica se o elemento atual é menor que o menor valor encontrado até agora
                if (N[i] < menorValor)
                {
                    // Atualiza o menor valor encontrado
                    menorValor = N[i];

                    // Atualiza a posição do menor valor
                    posicaoMenor = i;
                }
            }

            // Exibe o menor valor e sua posição no vetor
            Console.WriteLine($"O menor elemento de N é: {menorValor} e sua posição dentro do vetor é: {posicaoMenor}");

            Console.ReadKey();
        }
    }
}
    