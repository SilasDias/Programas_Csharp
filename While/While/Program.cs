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
            int valor = int.Parse(Console.ReadLine());

            do
            {
                valor++;
            } while (valor == 0);
            Console.WriteLine(valor);
            Console.ReadLine();
        }
    }
}
