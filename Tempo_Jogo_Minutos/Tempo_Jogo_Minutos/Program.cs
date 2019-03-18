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
            int inicio, minutos, fim, tempo, horainicial, horafinal, minutoinicial, minutofinal;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            horainicial = int.Parse(vet[0]);
            minutoinicial = int.Parse(vet[1]);
            horafinal = int.Parse(vet[2]);
            minutofinal = int.Parse(vet[3]);

            minutoinicial = minutoinicial * 0.01;
            minutofinal = minutofinal * 0.01;

            inicio = horainicial + minutoinicial;
            fim = horafinal + minutofinal;

            tempo = fim - inicio;

            if (tempo >= 1 && tempo <= 24)
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }
            else if (tempo < 0 || tempo == 0)
            {
                tempo = 24 + (fim - inicio);
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }


            Console.ReadLine();
        }
    }
}
