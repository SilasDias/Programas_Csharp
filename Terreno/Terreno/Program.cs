using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, precoMetroQuadrado;
            double area, preco;

            Console.WriteLine("Digite o Comprimento do Terreno = ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Largura do Terreno = ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Valor do Metro Quadrado ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = comprimento * largura;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine(); 
        }
    }
}
