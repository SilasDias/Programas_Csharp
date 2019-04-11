using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            n = int.Parse(Console.ReadLine());

            if(n < 10000)
            {
                for (i = 1; i <= 10000; i++)
                {
                    if(i % n == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            }            
        }
    }
}
