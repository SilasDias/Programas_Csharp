using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Soma_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a, b, c;

            n = int.Parse(Console.ReadLine());
            a = new int[n];
            b = new int[n];
            c = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            string[] r = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                b[i] = int.Parse(r[i]);
                c[i] = (a[i]+b[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(c[i]+" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
