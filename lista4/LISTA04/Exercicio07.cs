using System;

public class Exercicio07 {
    public void Rodar() {
        Console.Write("Informe o número de alunos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.Write("Informe a média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            ExibirConceito(media);
        }
    }

    public void ExibirConceito(double media) {
        char conceito;

        if (media < 40) {
            conceito = 'F';
        } else if (media < 60) {
            conceito = 'E';
        } else if (media < 70) {
            conceito = 'D';
        } else if (media < 80) {
            conceito = 'C';
        } else if (media < 90) {
            conceito = 'B';
        } else {
            conceito = 'A';
        }

        Console.WriteLine($"O conceito do aluno é: {conceito}");
    }
}
