using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }

            }
            if (x == 0 || y == 0)
            {

            }
            Console.ReadLine();
        }
    }
}  
