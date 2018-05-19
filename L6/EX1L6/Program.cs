using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1L6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int impar = 0;
            int par = 0;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Digite um numero");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var x in n)
            {
                if (x % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }

            Console.WriteLine("Os numeros pares são {0}:", par);
            Console.WriteLine("Os numeros impares são  {0}:", impar);

            Console.ReadKey();
        }
    }
}
