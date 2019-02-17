using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, horas;
            double valor, salario;

            id = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horas * valor;

            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
