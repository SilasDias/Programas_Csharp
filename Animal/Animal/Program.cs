using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, cadeia;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            if (a == "vertebrado")
            {
                if (b == "mamifero")
                {
                    if(c == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }

                }
                else
                {
                    if(c == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }

            }
            else
            {
                if(b == "inseto")
                {
                    if(c == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("largata");
                    }
                }
                else
                {
                    if(c == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            Console.ReadLine();


        }
    }
}
