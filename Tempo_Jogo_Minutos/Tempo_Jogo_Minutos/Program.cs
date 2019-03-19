using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo_de_Jogo_Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, hora, fim, tempo, horainicial, horafinal;
            double minutoinicial, minutofinal, minutos;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            horainicial = int.Parse(vet[0]);
            minutoinicial = int.Parse(vet[1]);
            horafinal = int.Parse(vet[2]);
            minutofinal = int.Parse(vet[3]);

            hora = horafinal - horainicial;
            minutos = minutofinal - minutoinicial;

            if (hora < 0)
            {
                hora += 24;
            }
            if ( minutos < 0)
            {
                minutos += 60;
                hora -= 1;
            }
            if (minutos == 0 && hora == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }else
            {
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTO(S)");
            }
            Console.ReadLine();
        }
    }
}
