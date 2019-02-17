using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GastodeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            litros = (double) (tempo * velocidade) / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
