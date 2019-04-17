using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia_de_Numeros_e_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, soma, i;

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
            for (i = min; i <= max; i++)
            {
                Console.Write(i);
                soma = soma + i;
            }
            Console.WriteLine("Sum="+soma);
            Console.ReadLine();
        }
    }
}
