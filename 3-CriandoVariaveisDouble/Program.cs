using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 - Utilizando variaveis DOUBLE");
            
            double num_1;
            num_1 = 2.50;
            Console.WriteLine(num_1);

            num_1 = 5 / 2;
            Console.WriteLine("5 / 2 = " + num_1);

            num_1 = 5.0 / 2;
            Console.WriteLine("5.0 / 2 = " + num_1);

            num_1 = 5 / 2.0;
            Console.WriteLine("5 / 2.0 = " + num_1);

            num_1 = 5;

            double num_2 = 2;

            Console.WriteLine("num_1 = double 5, num_2 = double 2 -> " + num_1 + " / " + num_2 + " = " + num_1 / num_2);

            Console.WriteLine("Pressione ENTER para encerrar o programa . . . ");
            Console.ReadLine();

        }
    }
}
