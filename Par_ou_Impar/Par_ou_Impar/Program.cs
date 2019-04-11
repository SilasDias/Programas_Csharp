using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            long x;

            n = int.Parse(Console.ReadLine());

            if(n < 10000)
            {
                for(i=0; i < n; i++)
                {
                    x = long.Parse(Console.ReadLine());
                    if (x == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                    else if (x >= 0 && x % 2 == 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    }else if (x >= 0 && x % 2 != 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }else if (x < 0 && x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }else if (x < 0 && x % 2 != 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
