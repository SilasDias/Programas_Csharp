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
                Console.WriteLine("R$ " +((salario-2000)*0.08).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                Console.WriteLine("R$ " + ((salario -3000)*0.18+(1000*0.08)).ToString("F2", CultureInfo.InvariantCulture));
            }else if (salario > 4500.00)
            {
                Console.WriteLine("R$ " + ((salario-4500)*0.28+(1500*0.18)).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {

            }
            Console.ReadLine();
        }
    }
}
