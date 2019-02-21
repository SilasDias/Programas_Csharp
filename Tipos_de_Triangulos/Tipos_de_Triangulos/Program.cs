using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tipos_de_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double  a, b, c, temp;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }else if(a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }else if(a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }else if(a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }else if(a == b || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            Console.ReadLine();
        }
    }
}
