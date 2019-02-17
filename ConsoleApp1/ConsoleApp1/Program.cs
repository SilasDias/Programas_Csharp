using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0, y = 4.0, z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("A Raiz Quadrada de " + x + " = " + A);
            Console.WriteLine("A Raiz Quadrada de " + y + " = " + B);
            Console.WriteLine("A Raiz Quadrada de 25 = " + C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao Quadrado = "+ B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor Absoluto de " + y + " = " + A);
            Console.WriteLine("Valor Absoluto de " + z + " = " + B);

            
            Console.ReadLine();



        }
    }
}
