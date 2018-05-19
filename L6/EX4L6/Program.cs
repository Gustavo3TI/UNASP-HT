using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4L6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;

            int contador =4 ;

            Console.WriteLine("Digite o número que deseja saber a tabuada.");

            numero = int.Parse(Console.ReadLine());



            if (numero < 0 || numero > 25)

            {

                Console.WriteLine("Número inválido por favor digite um número de 0 a 10"); 

            }

            else

            {

                while (contador < 8) 

                {

                    Console.WriteLine(numero + " x " +contador + " = " +numero * contador);

                    contador = contador + 1;

                }
                Console.ReadKey();

            }
        }
    }
}
