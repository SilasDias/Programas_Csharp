using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ImpostodeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                Console.WriteLine("R$ " +((salario*08)/100)+salario).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                juros = 10;
                ajuste = (salario * 10) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                juros = 07;
                ajuste = (salario * 07) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }
            else if (salario > 2000.00)
            {
                juros = 04;
                ajuste = (salario * 04) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }
            else
            {

            }
            Console.ReadLine();
        }
    }
}
