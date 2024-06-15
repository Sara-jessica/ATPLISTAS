using System;

public class Exercicio05 {
    public void Rodar() {
        Console.Write("Informe o primeiro número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número: ");
        int b = int.Parse(Console.ReadLine());

        int mdc = CalcularMDC(a, b);
        Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
    }

    public int CalcularMDC(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
