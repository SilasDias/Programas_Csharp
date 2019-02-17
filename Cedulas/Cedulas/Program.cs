using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, divisao, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            nota = 100;
            divisao = N / nota;
            Console.WriteLine(divisao+" nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = N % nota;

            nota = 50;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % nota;

            nota = 20;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % nota;

            nota = 10;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % nota;

            nota = 5;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % nota;

            nota = 2;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % nota;

            nota = 1;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % nota;

            Console.ReadLine();
        }
    }
}
