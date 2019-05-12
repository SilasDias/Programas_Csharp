using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor_Altura_Grupo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e
             * escreva: 
             * a maior e a menor altura do grupo
             * a média de altura das 
             * o número de homens*/

            int n;
            double menor = 0.0, maior=0.0;

            n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            char[] sexo = new char[n];

            //Leitura dos Dados
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = s[1];                
            }

            //Calculo das alturas
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + alturas[i];
                if(alturas[i] < menor)
                {
                    menor = alturas[i];
                }
                if(alturas[i] > maior)
                {
                    maior = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));

            // Media das mulheres
            for (int i = 0; i < n; i++)
            {
                if(sexo[i] == 'f' || sexo[i] == 'F')
                {
                    soma = soma + sexo[i];
                    int cont = cont + 1;
                }
            }
            double media = soma / cont;
            Console.WriteLine("Altura media: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //Quantidade de homens
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == 'm' || sexo[i] == 'M')
                {
                    cont++;
                }
            }
            Console.WriteLine("Numero de homens =" + cont);
            Console.ReadLine();
        }
    }
}
