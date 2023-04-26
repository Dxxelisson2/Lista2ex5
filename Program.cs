using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, t;


            Console.Write("Digite o valor de a1: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("digite o  valor de b1: ");
            a = double.Parse(Console.ReadLine());
            t = b * a;
            if (t > 100)
                Console.Write("terreno grande: " + t);
            else
                Console.Write("terreno pequeno: " + t);

        }
    }
}
