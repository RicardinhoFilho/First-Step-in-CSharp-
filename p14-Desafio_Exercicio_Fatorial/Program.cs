using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14_Desafio_Exercicio_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nesse exercício opcional, o seu desafio é imprimir os fatoriais de 1 a 10!
            Console.WriteLine("Projeto 14 - Fatorial");
            int numero = 6;

            for (int i = numero-1; i > 0; i--)
            {
                Console.WriteLine(i);
                numero = numero * i;
            }

            Console.WriteLine(numero);

            Console.ReadLine();
        }
    }
}
