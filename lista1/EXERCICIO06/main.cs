using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o valor de A:");
    double A = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de B:");
    double B = double.Parse(Console.ReadLine());


    double temp = A;
    A = B;
    B = temp;

    Console.WriteLine($"Valor final de A: {A}");
    Console.WriteLine($"Valor final de B: {B}");
  }
}