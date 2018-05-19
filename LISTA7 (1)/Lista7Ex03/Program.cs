using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivo = 0;
            int cont = 0;
            for (int i = 0; i > -1; i++)
            {
                cont++;
                Console.WriteLine("Digite um número: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    positivo++;
                }

                if (n == 0)
                {
                    cont--;
                    break;
                }
            }
            Console.WriteLine(" De {0} números, {1} são positivos! ", cont, positivo);
            Console.ReadKey();
        }
    }
}
