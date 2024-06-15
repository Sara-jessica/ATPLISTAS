using System;

public class Exercicio01 {
    public void Rodar() {
        Console.Write("Informe o número de alunos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.Write("Informe a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            
            Console.Write("Informe a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Informe 'A' para média aritmética ou 'P' para média ponderada: ");
            char tipoMedia = char.Parse(Console.ReadLine().ToUpper());

            CalcularMedia(nota1, nota2, nota3, tipoMedia);
        }
    }

    public void CalcularMedia(double nota1, double nota2, double nota3, char tipoMedia) {
        double media = 0;

        if (tipoMedia == 'A') {
            media = (nota1 + nota2 + nota3) / 3;
        } else if (tipoMedia == 'P') {
            media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
        }

        Console.WriteLine($"A média é: {media}");
    }
}
