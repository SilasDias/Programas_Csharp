using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Medias_Ponderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string[] vet;
                vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double z = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double media = ((x * 2) + (y * 3) + (z * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
