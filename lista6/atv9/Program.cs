using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Inserir dados de alunos");
                Console.WriteLine("2. Ler dados de alunos de um arquivo");
                Console.WriteLine("3. Sair");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    InserirDadosAlunos();
                }
                else if (opcao == "2")
                {
                    LerDadosAlunos();
                }
                else if (opcao == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

        static void InserirDadosAlunos()
        {
            string caminhoArquivo = "alunos.txt";

            // Abre o arquivo para escrita (append)
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                while (true)
                {
                    // Solicita ao usuário que insira a matrícula e o telefone do aluno
                    Console.WriteLine("Digite a matrícula do aluno (ou 'sair' para finalizar):");
                    string matricula = Console.ReadLine();
                    if (matricula.ToLower() == "sair")
                    {
                        break;
                    }

                    Console.WriteLine("Digite o telefone do aluno:");
                    string telefone = Console.ReadLine();

                    // Verifica se o usuário deseja sair ao digitar 'sair' para o telefone
                    if (telefone.ToLower() == "sair")
                    {
                        break;
                    }

                    // Escreve os dados no arquivo
                    writer.WriteLine($"Matrícula: {matricula}, Telefone: {telefone}");
                }
            }

            Console.WriteLine("Dados dos alunos foram salvos no arquivo 'alunos.txt'.");
        }

        static void LerDadosAlunos()
        {
            string caminhoArquivo = "alunos.txt";

            if (File.Exists(caminhoArquivo))
            {
                // Lê todas as linhas do arquivo e exibe na tela
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                Console.WriteLine("Dados dos alunos:");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }

            else
            {
                Console.WriteLine("O arquivo 'alunos.txt' não existe.");
            }
        }
    }
}