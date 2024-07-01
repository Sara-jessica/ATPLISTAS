using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite as coordenadas do primeiro ponto (x1 y1):");
        string[] ponto1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(ponto1[0]);
        double y1 = double.Parse(ponto1[1]);

        Console.WriteLine("Digite as coordenadas do segundo ponto (x2 y2):");
        string[] ponto2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(ponto2[0]);
        double y2 = double.Parse(ponto2[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine($"A distância entre os dois pontos é: {distancia}");
  }
}
