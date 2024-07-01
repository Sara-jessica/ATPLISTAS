using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a velocidade máxima permitida em km/h:");
        int velocidadeMaxima = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade do motorista em km/h:");
        int velocidadeMotorista = int.Parse(Console.ReadLine());

        if (velocidadeMotorista <= velocidadeMaxima)
        {
            Console.WriteLine("Motorista respeitou a lei.");
        }
        else
        {
            int diferencaVelocidade = velocidadeMotorista - velocidadeMaxima;
            int valorMulta;

            if (diferencaVelocidade <= 10)
            {
                valorMulta = 50;
            }
            else if (diferencaVelocidade <= 30)
            {
                valorMulta = 100;
            }
            else
            {
                valorMulta = 200;
            }

            Console.WriteLine("O motorista ultrapassou a velocidade máxima permitida.");
            Console.WriteLine("Valor da multa a ser cobrada: R$ " + valorMulta);
        }
    }
}
