using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor_Soma_e_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] a;
            n = int.Parse(Console.ReadLine());
            a = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for(int i=0; i<n; i++)
            {
                soma = soma + a[i];
            }
            double media = soma / n;
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
