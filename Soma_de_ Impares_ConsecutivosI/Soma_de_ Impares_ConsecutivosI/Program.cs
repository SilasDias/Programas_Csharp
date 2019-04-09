using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de__Impares_ConsecutivosI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            soma = 0;
            for(int i=min+1; i < max; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();

        }        
     }
 }
