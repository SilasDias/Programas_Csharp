using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo_de_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            double inicio, fim, tempo;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            inicio = double.Parse(vet[0]);
            fim = double.Parse(vet[1]);

            tempo = fim - inicio;

            if (tempo != 1 && tempo != 24)
            {
                if (tempo < 0)
                {
                    tempo = 24 + (fim - inicio);
                }

                if (tempo == inicio || tempo == 0)
                {
                    Console.WriteLine("O JOGO DUROU 24 HORA(S)");
                }
                else
                {
                    Console.WriteLine("O JOGO DUROU " + tempo + " HORAS(S)");
                }
            }
            Console.ReadLine();
        }
    }
}
