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

            tempo = fim - inicio;
            minutos = minutofinal - minutoinicial;

            if (minutos >= 1 && tempo <= 24)
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S) E " + minutos + " MINUTO(S)");
            }
            else if (tempo < 0 || tempo == 0 && minutos < 0 || minutos == 0)
            {
                    tempo = 24 + (fim - inicio);
                    minutos = 60 + (minutofinal - minutoinicial);
                    Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S) E " + minutos + " MINUTO(S)");
                }
            Console.ReadLine();
        }
    }
}
