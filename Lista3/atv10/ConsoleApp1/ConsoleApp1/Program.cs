using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoCompra, precoVenda;
            int mercadoriasLucroMenor10 = 0, mercadoriasLucroEntre10e20 = 0, mercadoriasLucroMaior20 = 0;
            double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

            Console.WriteLine("Informe o preço de compra e de venda de cada mercadoria (digite 0 para encerrar):");

            while (true)
            {
                Console.Write("Preço de compra: ");
                precoCompra = double.Parse(Console.ReadLine());

                if (precoCompra == 0)
                {
                    break;
                }

                Console.Write("Preço de venda: ");
                precoVenda = double.Parse(Console.ReadLine());

                totalCompra += precoCompra;
                totalVenda += precoVenda;

                double lucro = ((precoVenda - precoCompra) / precoCompra) * 100;

                if (lucro < 10)
                {
                    mercadoriasLucroMenor10++;
                }
                else if (lucro >= 10 && lucro <= 20)
                {
                    mercadoriasLucroEntre10e20++;
                }
                else
                {
                    mercadoriasLucroMaior20++;
                }

                lucroTotal += precoVenda - precoCompra;
            }

            Console.WriteLine($"Mercadorias com lucro < 10%: {mercadoriasLucroMenor10}");
            Console.WriteLine($"Mercadorias com lucro entre 10% e 20%: {mercadoriasLucroEntre10e20}");
            Console.WriteLine($"Mercadorias com lucro > 20%: {mercadoriasLucroMaior20}");
            Console.WriteLine($"Valor total de compra: {totalCompra}");
            Console.WriteLine($"Valor total de venda: {totalVenda}");
            Console.WriteLine($"Lucro total: {lucroTotal}");
        }
    }


}
   
