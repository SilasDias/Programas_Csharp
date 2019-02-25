using System;


namespace Tempo_de_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, tempo;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            tempo = fim - inicio;

            if(tempo >= 1 && tempo <= 24)
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }else if(tempo < 0 || tempo == 0)
            {
                tempo = 24 + (fim - inicio);
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }
            Console.ReadLine();
        }
    }
}
