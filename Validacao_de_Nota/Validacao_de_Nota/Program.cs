using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Validacao_de_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            while (nota1 >= 0 && nota1 <= 10 || nota2 >= 0 && nota2 <= 10)
            {
                media = (nota1 + nota2) / 2;
                Console.WriteLine("media = "+media.ToString("F2",CultureInfo.InvariantCulture));
            }
            if(nota1 < 0 && nota1 > 10 || nota2 < 0 && nota2 > 10)
            {
                Console.WriteLine("nota invalida");
            }
            Console.ReadLine();
        }
    }
}
