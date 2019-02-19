using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if(a > b && a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if(a < b && b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadLine();
        }
    }
}
