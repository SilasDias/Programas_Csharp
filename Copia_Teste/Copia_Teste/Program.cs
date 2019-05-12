using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Copia_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] altura;
            char[] gender;
            // Leitura inicial.
            N = int.Parse(Console.ReadLine());
            altura = new double[N];
            gender = new char[N];
            // Leitura dos dados.
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                gender[i] = char.Parse(vet[1]);
            }
            // Verificação da menor altura.
            int menor = 0;
            for (int i = 0; i < N; i++)
            {
                if (altura[i] < altura[menor])
                {
                    menor = i;
                }
            }
            Console.WriteLine("Menor altura = {0}", altura[menor].ToString("F2", CultureInfo.InvariantCulture));
            // Verificação da maior altura.
            int maior = 0;
            for (int i = 0; i < N; i++)
            {
                if (altura[i] > altura[maior])
                {
                    maior = i;
                }
            }
            Console.WriteLine("Maior altura = {0}", altura[maior].ToString("F2", CultureInfo.InvariantCulture));
            // Verificação da media de altura das mulheres.
            int cont = 0;
            double soma = 0.0, media;
            for (int i = 0; i < N; i++)
            {
                if (gender[i] == 'F')
                {
                    soma = soma + altura[i];
                    cont++;
                }
            }
            media = soma / cont;
            Console.WriteLine("Media das alturas das mulheres = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
            // Verificação da quantidade de homens.
            int qtdhomens = 0;
            for (int i = 0; i < N; i++)
            {
                if (gender[i] == 'M')
                {
                    qtdhomens++;
                }
            }
            Console.WriteLine("Numero de homens = {0}", qtdhomens);
            Console.ReadLine();
        }
    }
}
