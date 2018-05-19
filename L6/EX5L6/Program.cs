using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5L6
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalo1 = 0;
            int intervalo2 = 0;
            int intervalo3 = 0;
            int intervalo4 = 0;
            int num = 0;
            { 
            Convert.ToInt32((num >= 0) && (num <= 25)) intervalo1 = intervalo1 + 1;
            Convert.ToInt32((num >= 26) && (num <= 50)) intervalo2 = intervalo2 + 1;

            Convert.ToInt32((num >= 51) && (num <= 75)) intervalo3 = intervalo3 + 1;

            Convert.ToInt32((num >= 76) && (num <= 100)) intervalo4 = intervalo4 + 1;

}
        Console.ReadKey();

        }
        
    }
}
