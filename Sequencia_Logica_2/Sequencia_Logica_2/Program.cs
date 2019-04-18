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
            int x, y, min, max;

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
            for(int j = 0; j< max; j++) {
            for (int i = 0; i < min; i++)
            {
                    Console.Write(i + " ");
            }
            }
            Console.ReadLine();
        }
    }
}
