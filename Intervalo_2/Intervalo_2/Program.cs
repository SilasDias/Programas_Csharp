using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, i, dentro=0, fora=0;

           n = int.Parse(Console.ReadLine());

            for(i=0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }

            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
            Console.ReadLine();
        }
    }
}
