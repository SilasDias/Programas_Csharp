using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor_Media_Numeros_Reais
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;
            double media=0.0, soma=0.0;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i]);
                soma = (double) soma + vet[i];
            }

            media = (double) soma / n;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if(vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F2",CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
