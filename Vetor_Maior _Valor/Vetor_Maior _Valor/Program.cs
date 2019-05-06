using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor_Maior__Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1) Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
            do vetor(supor não haver empates).Mostrar também a posição do maior elemento.*/

            int n, x=0;
            double[] a;

            n = int.Parse(Console.ReadLine());
            a = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i]);
            }
            int e = 0;
            double valor=0;
            for (int i = 0; i < n; i++)
            {
                x++;
                if (a[i] > valor)
                {
                    e = x;
                    valor = (double) a[i];
                }
            }
            Console.WriteLine(valor.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
