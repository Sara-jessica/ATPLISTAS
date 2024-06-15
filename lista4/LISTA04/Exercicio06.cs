using System;

public class Exercicio06 {
    public void Rodar() {
        Console.Write("Informe o número de valores: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.Write("Informe um valor: ");
            int valor = int.Parse(Console.ReadLine());

            bool positivo = VerificarPositivo(valor);
            Console.WriteLine(positivo ? "Positivo" : "Negativo");
        }
    }

    public bool VerificarPositivo(int valor) {
        return valor >= 0;
    }
}
