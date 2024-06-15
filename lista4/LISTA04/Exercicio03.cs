using System;

public class Exercicio03 {
    public void Rodar() {
        Console.Write("Informe o número de conjuntos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.Write("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            ExibirOrdemCrescente(valor1, valor2, valor3);
        }
    }

    public void ExibirOrdemCrescente(int valor1, int valor2, int valor3) {
        int[] valores = { valor1, valor2, valor3 };
        Array.Sort(valores);
        Console.WriteLine($"Valores em ordem crescente: {valores[0]}, {valores[1]}, {valores[2]}");
    }
}
