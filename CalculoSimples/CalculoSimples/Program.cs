using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, quant1, codigo2, quant2;
            double valor1, valor2, total;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            quant1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet[0]);
            quant2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = quant1 * valor1 + quant2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
