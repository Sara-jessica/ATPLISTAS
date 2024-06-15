using System;

public class Exercicio09 {
    public void Rodar() {
        Console.Write("Informe o número de alunos: ");
        int n = int.Parse(Console.ReadLine());

        double mediaAprovados = CalcularMediaAprovados(n);
        Console.WriteLine($"A média das notas dos alunos aprovados é: {mediaAprovados}");
    }

    public double CalcularMediaAprovados(int n) {
        double total = 0;
        int count = 0;

        for (int i = 0; i < n; i++) {
            Console.Write("Informe a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6) {
                total += nota;
                count++;
            }
        }

        return count == 0 ? 0 : total / count;
    }
}
