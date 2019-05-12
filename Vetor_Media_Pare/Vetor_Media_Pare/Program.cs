using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Vetor_Media_Pare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont, soma = 0;
            double media=0;
            int[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    soma = soma + vet[i];
                    cont++;
                }
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
