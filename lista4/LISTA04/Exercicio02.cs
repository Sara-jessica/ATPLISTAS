using System;

public class Exercicio02 {
    public void Rodar() {
        int count = 0;
        double totalSalario = 0;

        while (true) {
            Console.Write("Informe o salário (ou -1 para encerrar): ");
            double salario = double.Parse(Console.ReadLine());

            if (salario == -1) break;

            Console.Write("Informe o número de filhos: ");
            int filhos = int.Parse(Console.ReadLine());

            totalSalario += salario;
            count++;
        }

        double mediaSalario = count == 0 ? 0 : totalSalario / count;
        Console.WriteLine($"A média de salário é: {mediaSalario}");
    }
}
