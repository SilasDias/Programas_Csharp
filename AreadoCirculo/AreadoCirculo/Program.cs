using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AreadoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            raio = Math.Pow(raio, 2);
            area = raio * 3.14159;
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
