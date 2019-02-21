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

           /* if (a > b && a > c && b > c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                x = (double)a;
                y = (double)b;
                z = (double)c;
            }else if (a > b && a > c && c > b)
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
                x = (double)a;
                y = (double)c;
                z = (double)b;
            }
            else if (b > a && b > c && a > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
                x = (double) b;
                y = (double) a;
                z = (double) c; 
            }
            else if (b > a && b > c && c > a)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
                x = (double)b;
                y = (double)c;
                z = (double)a;
            }
            else if (c > a && c > b && a > b)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
                x = (double)c;
                y = (double)a;
                z = (double)b;
            }
            else if (c > a && c > b && b > a)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
                x = (double)c;
                y = (double)b;
                z = (double)a;
            }*/
            Console.ReadLine();
        }
    }
}
