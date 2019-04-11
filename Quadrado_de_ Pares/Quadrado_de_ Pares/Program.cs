using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_de__Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            long n;

            n = long.Parse(Console.ReadLine());

            if (n > 5 && n < 2000)
            {

                for (i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + "^2 = " + i * i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
