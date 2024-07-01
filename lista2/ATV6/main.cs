using System;

class Program
{
    static void Main()
    {
        int totalApartamentos = 75;
        double ocupacaoNormal = 0.5;
        double ocupacaoPromocional = 0.8;
        double desconto = 0.25;
        double valorDiariaNormal = 100;


        double valorDiariaPromocional = valorDiariaNormal - (valorDiariaNormal * desconto);
        Console.WriteLine("Valor da diária promocional: R$" + valorDiariaPromocional);


        double totalArrecadadoPromocional = totalApartamentos * ocupacaoPromocional * valorDiariaPromocional;
        Console.WriteLine("Valor total arrecadado com 80% de ocupação e diária promocional: R$" + totalArrecadadoPromocional);


        double totalArrecadadoNormal = totalApartamentos * ocupacaoNormal * valorDiariaNormal;
        Console.WriteLine("Valor total arrecadado com 50% de ocupação e diária normal: R$" + totalArrecadadoNormal);


        double diferenca = totalArrecadadoPromocional - totalArrecadadoNormal;
        Console.WriteLine("Diferença entre os dois valores: R$" + diferenca);
    }
}
