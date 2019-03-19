using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AumentodeSalário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, ajuste, juros, total;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 400.00)
            {
                juros = 15;
                ajuste = (salario * 15) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " +total.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+juros+" %");
            }else if (salario > 400.00 && salario <= 800.00)
            {
                juros = 12;
                ajuste = (salario * 12) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }else if (salario > 800.00 && salario <= 1200.00)
            {
                juros = 10;
                ajuste = (salario * 10) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }else if (salario > 1200.00 && salario <= 2000.00)
            {
                juros = 07;
                ajuste = (salario * 07) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }else if (salario > 2000.00)
            {
                juros = 04;
                ajuste = (salario * 04) / 100;
                total = salario + ajuste;
                Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + juros + " %");
            }else
            {

            }
            Console.ReadLine();
        }
    }
}
