using System;

public class Exercicio10
{
    public void Rodar()
    {
        Console.Write("Informe a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());

        char categoria = DeterminarCategoria(idade);
        Console.WriteLine($"A categoria do nadador é: {categoria}");
    }

    public char DeterminarCategoria(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            return 'F';
        }
        else if (idade >= 8 && idade <= 10)
        {
            return 'E';
        }
        else if (idade >= 11 && idade <= 13)
        {
            return 'D';
        }
        else if (idade >= 14 && idade <= 15)
        {
            return 'C';
        }
        else if (idade >= 16 && idade <= 17)
        {
            return 'B';
        }
        else
        {
            return 'A';
        }
    }
}