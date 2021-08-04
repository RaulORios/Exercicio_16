using System;

namespace Exercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 16     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int Quantidade;
            double resultado;

            Console.WriteLine("Na compra a partir de 12 Maçãs o valor sairá por R$ 1,00 a unidade.");

            Console.WriteLine("Na compra abaixo de 12 Maçãs o valor será de R$ 1,30 a unidade.");

            Console.WriteLine("");

            Console.Write("Informe quantas maçãs você deseja comprar: ");
            Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (Quantidade < 12)
            {
                resultado = Quantidade * 1.3;
            }
            else
            {
                resultado = Quantidade * 1;
            }

            Console.WriteLine($"O valor das {Quantidade} maças será de R$ {resultado} reais.");

            Console.ReadKey();
                                                              
        }
    }
}
