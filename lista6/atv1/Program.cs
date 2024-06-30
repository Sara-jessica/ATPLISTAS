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

            // Solicita ao usuário que insira uma frase
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Inicializa a contagem de espaços em branco
            int contadorEspacos = 0;

            // Percorre cada caractere da frase
            foreach (char c in frase)
            {
                // Verifica se o caractere é um espaço em branco
                if (c == ' ')
                {
                    contadorEspacos++;
                }
            }

            // Exibe a contagem de espaços em branco
            Console.WriteLine($"A frase contém {contadorEspacos} espaços em branco.");

            Console.ReadKey();
        }
    }
}
  
