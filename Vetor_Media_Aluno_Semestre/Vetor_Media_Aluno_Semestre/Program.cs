using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor_Media_Aluno_Semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no
             * 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes
             * dos alunos aprovados, considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.*/

            int n, e = 0;
            double media=0.0;

            n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            double[] semestre1 = new double[n];
            double[] semestre2 = new double[n];

            //Leitura dos dados
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                semestre1[i] = double.Parse(s[1]);
                semestre2[i] = double.Parse(s[2]);
            }

            //Calculo dos alunos aprovados
            for (int i = 0; i < n; i++)
            {
                media = (semestre1[i] + semestre2[i]) / 2;
                if (media >= 60.0)
                {
                    e = i;
                    Console.WriteLine(nomes[e]);
                }
            }
            Console.ReadLine();

        }
    }
}
