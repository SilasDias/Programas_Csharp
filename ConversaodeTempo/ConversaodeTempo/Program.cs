using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaodeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, horas, minutos, segundos, restoMinutos;


            n = int.Parse(Console.ReadLine());
            horas = n / 3600;
            minutos = (n % 3600) / 60;
            segundos = (n%3600) % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            Console.ReadLine();
        }
    }
}
