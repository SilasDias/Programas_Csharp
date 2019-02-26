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
            int inicio, minutoinicial, minutofinal, minutos, fim, tempo;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            inicio = int.Parse(vet[0]);
            minutoinicial = int.Parse(vet[1]);
            fim = int.Parse(vet[2]);
            minutofinal = int.Parse(vet[3]);

            tempo = inicio - fim;
            if(tempo < 0)
            {
                tempo = 24 + (inicio - fim);
            }
            minutos = minutoinicial - minutofinal;
            if(minutos < 0)
            {
                minutos = 60 + (minutoinicial - minutofinal);
                tempo--;
            }

            if (inicio == fim && minutoinicial == minutofinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S) E " + minutos+ " MINUTO(S)");
            }
           
            Console.ReadLine();
        }
    }
}
