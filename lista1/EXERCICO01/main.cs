using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a base do retângulo:");
    double baseR = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura do retângulo:");
    double alturaR = double.Parse(Console.ReadLine());

    double perimetro = 2 * (baseR + alturaR);
    double area = baseR * alturaR;
    double diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(alturaR, 2));

    Console.WriteLine($"Perímetro: {perimetro}");
    Console.WriteLine($"Área: {area}");
    Console.WriteLine($"Diagonal: {diagonal}");
  }
}