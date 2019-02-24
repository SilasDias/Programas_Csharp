using System;


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

            if(inicio == fim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            if (fim < inicio)
            {
                tempo = ((24 - inicio) + fim);
            }else {
                tempo = (fim - inicio);

            } if(tempo < 24 && tempo > 1)
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");

            }
            Console.ReadLine();
        }
    }
}
