using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somando_Inteiros_Consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i = 1, j = 0, soma = 0;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);

            while (int.Parse(vet[i]) <= 0)
            {
                i++;
            }
            y = int.Parse(vet[i]);
            for (i = 1; i < y; i++)
            {
                soma++;
            }
            Console.WriteLine(soma + (x * y));
            Console.ReadLine();
        }
    }
}
