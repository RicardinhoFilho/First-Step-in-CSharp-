using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_Exercicio_Multiplos_de_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.

            Console.WriteLine("Projeto 13 - Multiplos de 3");

            //forma utilizando resto da divisão
            Console.WriteLine("Maneira 1");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine( i );
                }
                else
                {
                    continue;
                }
            }

            //forma utilizando + 3
            Console.WriteLine("Maneira 2");
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Pressione ENTER para finalizar execição");
            Console.ReadLine();
        }
    }
}
