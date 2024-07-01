using System;

class Program {
  public static void Main (string[] args) {

    {
        Console.WriteLine("Digite o valor do cateto oposto:");
        double catetooposto = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do cateto adjacente:");
        double catetoAdjacente = double.Parse(Console.ReadLine());

        double hipotenusa = Math.Sqrt(Math.Pow(catetooposto, 2) + Math.Pow(catetoAdjacente, 2));

        Console.WriteLine($"A hipotenusa do triângulo retângulo é: {hipotenusa}");
  }
}
  }