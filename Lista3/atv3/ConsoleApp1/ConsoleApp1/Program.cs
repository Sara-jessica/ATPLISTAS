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
            int divisivelPor3e9 = 0, divisivelPor2e5 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                bool div3e9 = DivisivelPor3e9(num);
                bool div2e5 = DivisivelPor2e5(num);

                if (div3e9 && div2e5)
                {
                    divisivelPor3e9++;
                    divisivelPor2e5++;
                }
                else if (div3e9)
                {
                    divisivelPor3e9++;
                }
                else if (div2e5)
                {
                    divisivelPor2e5++;
                }
                else
                {
                    Console.WriteLine("Número não é divisível pelos valores.");
                }
            }

            Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divisivelPor3e9}");
            Console.WriteLine($"Quantidade de números divisíveis por 2 e 5: {divisivelPor2e5}");
        }

        static bool DivisivelPor3e9(int num)
        {
            int somaAlgarismos = 0;
            foreach (char c in num.ToString())
            {
                somaAlgarismos += int.Parse(c.ToString());
            }
            return somaAlgarismos % 3 == 0 && somaAlgarismos % 9 == 0;
        }

        static bool DivisivelPor2e5(int num)
        {
            return num % 2 == 0 && num % 5 == 0;
        }
    }

}
   