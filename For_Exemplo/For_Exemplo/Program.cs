using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, cont, soma;

            n = int.Parse(Console.ReadLine());
            soma = 0;
            for (cont=0;cont<n;cont++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma +x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();            
        }
    }
}
