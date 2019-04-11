using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_e_Posicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, n, e=0, a=0, b, i;

            for (i = 0; i < 100; i++)
            {
                n = int.Parse(Console.ReadLine());
                x++;
                if (n > e) {

                    a = x;
                    e = n;
                }
            }
            Console.WriteLine(e);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
