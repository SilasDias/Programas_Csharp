using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, soma;
            valor = int.Parse(Console.ReadLine());

            soma = 0;
            while (valor != 0)
            {
                valor = int.Parse(Console.ReadLine());
                soma++;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
