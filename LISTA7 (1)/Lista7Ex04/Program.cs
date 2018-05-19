using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double cont = 0;

            for (int i = 0; i > -1; i++)
            {
                Console.WriteLine("Digite um número: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 2 == 0)
                {
                    soma += n;
                    cont++;
                }
                else
                {
                    Console.WriteLine("Este número é ímpar!!!");
                }

                if (n == 0)
                {
                    cont--;
                    break;
                }
            }

            double media = soma / cont;

            Console.WriteLine("A media de todos os números pares digitados é: {0}", media);

            Console.ReadKey();
        }
    }
}
