using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeemDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, dias, meses, ano, resto;

            idade = int.Parse(Console.ReadLine());
            ano = idade / 365;
            resto = idade % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(ano + " ano(s) ");
            Console.WriteLine(meses + " mes(es) ");
            Console.WriteLine(dias + " dia(s) ");

            Console.ReadLine();

        
        }
    }
}
