using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quant = int.Parse(vet[1]);

            if (codigo == 1)
            {
                Console.WriteLine("Total: R$ " + (quant * 4).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 2)
            {
                Console.WriteLine("Total: R$ " + (quant * 4.5).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 3)
            {
                Console.WriteLine("Total: R$ " + (quant * 5).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 4)
            {
                Console.WriteLine("Total: R$ " + (quant * 2).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 5)
            {
                Console.WriteLine("Total: R$ " + (quant * 1.5).ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
