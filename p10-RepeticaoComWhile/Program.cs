using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_RepeticaoComWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Laço de repetição WHILE");
            
            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                //contador = contador + 1;
                //contador += 1; 
                contador++;
            }
            Console.WriteLine("Tecle ENTER para finalizar execução . . .");
            Console.ReadLine();
        }
    }
}
