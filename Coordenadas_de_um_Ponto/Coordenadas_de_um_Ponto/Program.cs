using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Coordenadas_de_um_Ponto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0],CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1],CultureInfo.InvariantCulture);

            if(x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }else if(x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }else if(x >0 && y > 0)
            {
                Console.WriteLine("Q1");
            }else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }else if(x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }else if(x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
            Console.ReadLine();
        }
    }
}
