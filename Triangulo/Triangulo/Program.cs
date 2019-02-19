using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if((b-c) < a && a < (b+c) && (a-c) < b && b < (a+c) && (a-b) < c && c < (a+b))
            {
                Console.WriteLine("Perimetro = " + (a + b + c).ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Area = " + (((a + b)*c)/2).ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
