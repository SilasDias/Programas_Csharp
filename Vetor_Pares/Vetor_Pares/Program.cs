using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            int[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            cont = 0;
            for (int i = 0; i < n; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    Console.Write(vet[i]+" ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
            Console.ReadLine();
        }
    }
}
