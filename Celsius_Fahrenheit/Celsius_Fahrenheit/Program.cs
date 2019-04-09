using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Celsius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char escolha;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine());
                f = 9.0 * c / 5.0 + 32;
                Console.WriteLine("Equivalente a Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja Repetir (S/N)?: ");
                escolha = char.Parse(Console.ReadLine());
            } while (escolha == 's');
            Console.ReadLine();
        }
    }
}
