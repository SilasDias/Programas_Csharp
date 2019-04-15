using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_Impares_Consecutivos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, soma, n, i, j=0;

            n = int.Parse(Console.ReadLine());

            do
            {

                string[] vet;
                vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (x < y)
                {
                min = x;
                max = y;
                }
                else
                {
                min = y;
                max = x;
                }
                soma = 0;
                for (i = min+1; i < max; i++)
                {
                    if (i % 2 != 0)
                        {
                        soma = soma + i;
                        }
                }
                Console.WriteLine(soma);
                j++;
            } while(j < n);
            Console.ReadLine();
        }
    }
}
