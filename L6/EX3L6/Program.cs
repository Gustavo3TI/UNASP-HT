using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3L6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Digite o numero para recebe-lo em fatorial");
                int f = Convert.ToInt16(Console.ReadLine());

                int[] fatorial = new int[f];
                int num = 1;
                int resultado = 1;


                for (int i = 0; i <= (f - 1); i++)
                {
                    if (i == 0)
                    {
                        fatorial[i] = f;
                    }
                    else
                    {
                        fatorial[i] = f - num;
                        num++;
                    }
                }



                foreach (var calc in fatorial)
                {
                    resultado = resultado * calc;
                }

                Console.WriteLine("Seu resultado {0}", resultado);
                Console.ReadKey();
            }
        
    }
    }
}
