using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equa2Grau
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta;
            double a, b, c;
            double x1, x2;
            delta = Math.Pow(b, 2.0) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);


        }
    }
}
