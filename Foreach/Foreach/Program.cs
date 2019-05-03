using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            string[] vet = new string[n];

            for(int i=0; i<n; i++)
            {
                vet[i] = Console.ReadLine();
            }
            Console.WriteLine("Nomes lidos: ");
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadLine();
        }
    }
}
