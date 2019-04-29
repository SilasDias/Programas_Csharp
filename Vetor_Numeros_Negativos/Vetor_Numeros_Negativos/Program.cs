using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Numeros_Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
            Console.ReadLine() ;
        }
    }
}
