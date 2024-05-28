using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFunctionOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual operação você deseja fazer[M-multiplicaçaõ/D-divisão/A-adição/S-subtração]");
            string operacao = Console.ReadLine().ToLower();

            Console.Write("Digite o primeiro valor:");
            double valorUm = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            double valorDois = double.Parse(Console.ReadLine());

            calcular(operacao, valorUm, valorDois);

            Console.ReadKey();
        }

        static void calcular(string operacao, double valorUm, double valorDois)
        {
            double resultado = 0;
            switch (operacao)
            {
                case "m":
                    resultado = valorUm * valorDois;
                    break;

                case "s":
                    resultado = valorUm - valorDois;
                    break;

                case "a":
                    resultado = valorUm + valorDois;
                    break;

                case "d":
                    resultado = valorUm / valorDois;
                    break;

                default:
                    Console.WriteLine("Operação incorreta");
                    break;
            }
            Console.WriteLine("O resultado da operação foi: "+resultado);
        }
    }
}
