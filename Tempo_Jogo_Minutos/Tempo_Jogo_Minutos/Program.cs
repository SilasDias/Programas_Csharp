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

            Console.WriteLine(hora);
            Console.WriteLine(minutos);

            if (hora < 0 && minutos > 0)
            {
                minutos = minutos - 60;
                hora = 0;
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E "+minutos+" MINUTO(S)");
            } else if (minutos < 0 && hora > 0)
            {
                minutos = minutos + 60;
                hora = hora - 1;
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTO(S)");
            }else if (hora == 0 && minutos == 0)
            {
                hora = 24;
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTO(S)");
            }
            /*
            if (tempo >= 1 && tempo <= 24)
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }
            else if (tempo < 0 || tempo == 0)
            {
                tempo = 24 + (fim - inicio);
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }*/


            Console.ReadLine();
        }
    }
}
