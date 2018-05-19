using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2L6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(" Digite um termo");
                int t = Convert.ToInt16(Console.ReadLine());

                int[] Firreira= new int[t];
                Firreira[0] = 1;
                int num = 0;

                for (int i = 0; i < t - 1; i++)
                {
                    if (i != t - 1)
                    {
                        Firreira[i + 1] = Firreira[i] + num;
                    }

                    num = Firreira[i];

                }

                Console.WriteLine("O termo desejado é {0}", Firreira[t - 1]);
                Console.ReadKey();
            }

        }
    }
}
