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
            double media=0, soma=0;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
                soma = vet[i] + soma;
            }
            media = soma / n;
            Console.WriteLine(media);
            for (int i = 0; i < n; i++)
            {
                if(vet[i] < media)
                {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
