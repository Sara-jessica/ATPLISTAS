using System;

class Program
{
    public static void Main(string[] args)
    {
        int anoNascimento, idade;
        string fezAniversario;

        Console.WriteLine("Digite o ano de nascimento:");
        anoNascimento = int.Parse(Console.ReadLine());

        Console.WriteLine("Você já fez aniversário este ano? (S/N)");
        fezAniversario = Console.ReadLine();

 
        int anoAtual = DateTime.Now.Year;


        idade = fezAniversario.ToUpper() == "S" ? anoAtual - anoNascimento : anoAtual - anoNascimento - 1;

        Console.WriteLine("Sua idade é: " + idade);

        if (idade >= 18)
        {
            Console.WriteLine("Você já tem idade para tirar a Carteira de Habilitação.");
        }
        else
        {
            Console.WriteLine("Você ainda não tem idade para tirar a Carteira de Habilitação.");
        }
    }
}
