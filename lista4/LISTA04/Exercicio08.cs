using System;

public class Exercicio08 {
    public void Rodar() {
        Console.Write("Informe um valor inteiro e positivo N: ");
        int n = int.Parse(Console.ReadLine());

        double resultado = CalcularS(n);
        Console.WriteLine($"O valor de S é: {resultado}");
    }

    public double CalcularS(int n) {
        double s = 0;

        for (int i = 1; i <= n; i++) {
            s += (double)(i * i + 1) / (i + 3);
        }

        return s;
    }
}
