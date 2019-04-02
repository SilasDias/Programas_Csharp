using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Varias_Notas_Com_Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            int x;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x = 0;

            while(x != 2) { 

            media = 0.0;
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (nota1 + nota2) / 2;

            if (media != 0.0)
            {
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            x = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
