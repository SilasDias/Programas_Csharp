using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaseMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota, resto, divisao, money, moeda;
            double n;

            Console.WriteLine("NOTAS:");

            n = double.Parse(Console.ReadLine());

            // Vamos multiplicar N por 100 e forçar a conversão para int.
            // Desse modo, por exemplo, 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar 
            // que o numero seja devidamente arredondado

            money = (int)(n *1);
                        
            // como multiplicamos o valor por 100 acima, o valor de cada nota
            // também deverá ser multiplicado por 100 a seguir

            nota = 100;
            divisao = money / (nota * 100);
            Console.WriteLine(divisao + " notas(s) de R$ " + nota+".00");
            resto = money % (nota*100);

            nota = 50;
            divisao = resto / (nota * 100);
            Console.WriteLine(divisao + " notas(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            divisao = resto / (nota * 100);
            Console.WriteLine(divisao + " notas(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            divisao = resto / (nota * 100);
            Console.WriteLine(divisao + " notas(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            divisao = resto / (nota * 100);
            Console.WriteLine(divisao + " notas(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            divisao = resto / (nota * 100);
            Console.WriteLine(divisao + " notas(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");
            
            moeda = 100;
            divisao = resto / moeda;
            Console.WriteLine(divisao + " moeda(s) de R$ 1.00");
            resto = resto % (moeda);

            moeda = 50;
            divisao = resto / moeda;
            Console.WriteLine(divisao + " moeda(s) de R$ 0.50");
            resto = resto % (moeda);

            moeda = 25;
            divisao = resto / moeda;
            Console.WriteLine(divisao + " moeda(s) de R$ 0.25");
            resto = resto % (moeda);

            moeda = 10;
            divisao = resto / moeda;
            Console.WriteLine(divisao + " moeda(s) de R$ 0.10");
            resto = resto % (moeda);

            moeda = 5;
            divisao = resto / moeda;
            Console.WriteLine(divisao + " moeda(s) de R$ 0.05");
            resto = resto % (moeda);

            moeda = 1;
            divisao = resto / moeda;
            Console.WriteLine(divisao + " moeda(s) de R$ 0.01");
            resto = resto % (moeda);



            Console.ReadLine();
        }
    }
}
