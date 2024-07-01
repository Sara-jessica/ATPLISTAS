using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o valor do salário mínimo:");
        double salarioMinimo = double.Parse(Console.ReadLine());

        double valorKilowatt = salarioMinimo / 7 / 100;

        Console.WriteLine($"O valor em reais de cada kilowatt é: R$ {valorKilowatt}");

        Console.WriteLine("Digite a quantidade de kilowatts gasta na residência:");
        double kilowattsGastos = double.Parse(Console.ReadLine());

        double valorPago = valorKilowatt * kilowattsGastos;

        Console.WriteLine($"O valor em reais a ser pago é: R$ {valorPago}");

        double valorComDesconto = valorPago * 0.9;

    Console.WriteLine($"O novo valor a ser pago com desconto de 10% é: R$ {valorComDesconto}");
 
  }
}