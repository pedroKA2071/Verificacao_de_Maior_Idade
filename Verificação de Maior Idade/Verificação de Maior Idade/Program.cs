using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_de_Maior_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float idade;

            Console.WriteLine("Qual a sua idade?");
            idade = float.Parse(Console.ReadLine());

            if (idade >= 18) 
            {

                Console.WriteLine("Voce é maior de idade!");


            }
            else
            {
                Console.WriteLine("Voce é menor de idade!");
            }

            Console.ReadKey();

        }
    }
}
