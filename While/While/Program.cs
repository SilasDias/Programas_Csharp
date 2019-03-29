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
                Console.WriteLine(valor);
                valor++;
            } while (valor == 0);
            Console.ReadLine();
        }
    }
}
