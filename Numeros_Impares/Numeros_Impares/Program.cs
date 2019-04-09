using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, impar;

            x = int.Parse(Console.ReadLine());

            for(i=0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
