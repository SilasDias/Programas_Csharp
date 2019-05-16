using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor_Lucro_Mercadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, 
             * mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda
             * das mesmas. Fazer um programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
             * lucro< 10%
             * 10% ≤ lucro ≤ 20%
             * lucro> 20%
             * Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o
             * lucro total.*/

            int n;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];

            //Leitura dos Dados
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                compra[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //Calculo de lucro abaixo de 10% e entre 10 e 20%
            double diferenca = 0.0;
            int contBaixo = 0;
            int contEntre = 0;
            int contAcima = 0;
            double porcentagem = 0.0;
            for (int i = 0; i < n; i++)
            {
                diferenca = (venda[i] - compra[i]);
                porcentagem = (diferenca * 100) / compra[i];
                if (porcentagem < 10)
                {
                    contBaixo++;
                }
                else if (porcentagem >= 10 && porcentagem <= 20)
                {
                    contEntre++;
                }
                else if (porcentagem > 20)
                {
                    contAcima++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contBaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre);
            Console.WriteLine("Lucro acima de 20%: " + contAcima);

            //Calculo total de compra e venda
            double totalCompra = 0.0;
            double totalVenda = 0.0;
            for (int i = 0; i < n; i++)
            {
                totalCompra = totalCompra + compra[i];
                totalVenda = totalVenda + venda[i];

            }
            double lucro = totalVenda - totalCompra;
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}