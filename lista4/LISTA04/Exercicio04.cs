using System;

public class Exercicio04 {
    public void Rodar() {
        while (true) {
            Console.Write("Informe o valor do lado X (ou -1 para encerrar): ");
            double x = double.Parse(Console.ReadLine());

            if (x == -1) break;

            Console.Write("Informe o valor do lado Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do lado Z: ");
            double z = double.Parse(Console.ReadLine());

            VerificarTriangulo(x, y, z);
        }
    }

    public void VerificarTriangulo(double x, double y, double z) {
        if (x + y > z && x + z > y && y + z > x) {
            if (x == y && y == z) {
                Console.WriteLine("Triângulo Equilátero");
            } else if (x == y || x == z || y == z) {
                Console.WriteLine("Triângulo Isósceles");
            } else {
                Console.WriteLine("Triângulo Escaleno");
            }
        } else {
            Console.WriteLine("Não é um triângulo");
        }
    }
}
