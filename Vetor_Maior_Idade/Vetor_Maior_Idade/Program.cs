using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Maior_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois,
             * mostrar na tela o nome da pessoa mais velha.*/

            int n, x = 0, e=0, valor=0;

            n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];

            //Leitura dos dados
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

           //Nome com idade maior
            for (int i = 0; i < n; i++)
            {
                if (idades[i] > valor)
                {
                    e = i;
                    valor = idades[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: "+nomes[e]);
            Console.ReadLine();
        }
    }
}
