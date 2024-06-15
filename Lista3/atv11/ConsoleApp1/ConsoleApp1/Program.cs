using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voto, candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, votosNulos = 0, votosBranco = 0;

            Console.WriteLine("Digite o código do candidato (1 a 4), 5 para voto nulo, 6 para voto em branco e 0 para encerrar:");

            while (true)
            {
                voto = int.Parse(Console.ReadLine());

                if (voto == 0)
                {
                    break;
                }

                switch (voto)
                {
                    case 1:
                        candidato1++;
                        break;
                    case 2:
                        candidato2++;
                        break;
                    case 3:
                        candidato3++;
                        break;
                    case 4:
                        candidato4++;
                        break;
                    case 5:
                        votosNulos++;
                        break;
                    case 6:
                        votosBranco++;
                        break;
                    default:
                        Console.WriteLine("Código inválido. Digite novamente.");
                        break;
                }
            }

            Console.WriteLine($"Total de votos para o candidato 1: {candidato1}");
            Console.WriteLine($"Total de votos para o candidato 2: {candidato2}");
            Console.WriteLine($"Total de votos para o candidato 3: {candidato3}");
            Console.WriteLine($"Total de votos para o candidato 4: {candidato4}");
            Console.WriteLine($"Total de votos nulos: {votosNulos}");
            Console.WriteLine($"Total de votos em branco: {votosBranco}");
        }
    }


}
    