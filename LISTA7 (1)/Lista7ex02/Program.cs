using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int contar = 0;
            Console.WriteLine(" Números pares de 85 á 907 ");

            for (int i = 85; i <= 907; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("\n\n" + i);
                    contar += i;
                }
            }

            Console.WriteLine("\n\nA soma de todos eles é: {0}!!!", contar);

            Console.ReadKey();

        }
    }
}
