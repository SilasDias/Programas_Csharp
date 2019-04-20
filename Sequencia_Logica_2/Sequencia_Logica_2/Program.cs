using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia_Logica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, i, j=0, dividi=0;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

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
            for (i = 1; i <= max; i++)
            {
                Console.Write(i);
                j++;

                if (i < max && j != min)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                    j = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
