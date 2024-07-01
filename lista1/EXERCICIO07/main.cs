using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a quantidade de dias sem acidentes:");
    int dias = int.Parse(Console.ReadLine());

    int anos = dias / 365;
    int meses = (dias % 365) / 30;
    int diasRestantes = (dias % 365) % 30;

    Console.WriteLine($"{anos} anos, {meses} meses e {diasRestantes} dias sem acidentes.");
  }
}