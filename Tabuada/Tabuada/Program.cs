using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            n = int.Parse(Console.ReadLine());

            if( n >= 2 && n <= 1000)
            {
                for(i=1; i <= 10; i++)
                {
                    Console.WriteLine(i + " x " + n + " = " + i * n);
                }

            }
            Console.ReadLine();
        }
    }
}
