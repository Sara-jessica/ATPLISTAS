using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Digite o número da conta corrente (3 dígitos):");
    string contaCorrente = Console.ReadLine();

    if (contaCorrente.Length != 3)
    {
        Console.WriteLine("Número de conta inválido. A conta deve ter 3 dígitos.");
        return;
    }

    int numero = int.Parse(contaCorrente);
    int inverso = int.Parse("" + contaCorrente[2] + contaCorrente[1] + contaCorrente[0]);

    int soma = numero + inverso;
    int digitoVerificador = 0;

    for (int i = 0; i < contaCorrente.Length; i++)
    {
        int digito = soma % 10;
        digitoVerificador += digito * i;
        soma /= 10;
    }

    Console.WriteLine($"O dígito verificador é: {digitoVerificador % 10}");

  }
}