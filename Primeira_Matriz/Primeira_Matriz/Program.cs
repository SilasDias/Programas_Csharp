using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;

            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            a = new int[m, n];

            for(int i=0; i < m; i++) {
                string[] s = Console.ReadLine().Split(' ');
                    for(int j = 0; j < n; j++) {
                        a[i, j] = int.Parse(s[j]);
                     }
            }

            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
