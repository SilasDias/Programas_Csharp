using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {

            int ddd = int.Parse(Console.ReadLine());
            string estado;

            switch (ddd)
            {
                case 11:
                    estado = "Sao Paulo";
                    break;
                case 61:
                    estado = "Brasilia";
                    break;
                case 71:
                    estado = "Salvador";
                    break;
                case 21:
                    estado = "Rio de Janeiro";
                    break;
                case 32:
                    estado = "Juiz de Fora";
                    break;
                case 19:
                    estado = "Campinas";
                    break;
                case 27:
                    estado = "Vitoria";
                    break;
                case 31:
                    estado = "Belo Horizonte";
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }
            Console.WriteLine(estado);
            Console.ReadLine();

        }
    }
}
