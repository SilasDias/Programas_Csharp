using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, prod;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            prod = a * b;
            Console.WriteLine("PROD = " + prod);
            Console.ReadLine();
        }
    }
}
