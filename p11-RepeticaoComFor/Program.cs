using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_RepeticaoComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Utilização da estrutura de repetição FOR");

            //Investi R$1000, taxa mensal = 0,036% ao mês, qual será meu dinheiro em um ano
            double investimento_inicial = 1000;
            
            for (int contador_mes = 1; contador_mes <= 12; contador_mes++)
            {
                //investimento_inicial = investimento_inicial + investimento_inicial * 0.0036;
                //investimento_inicial = investimento_inicial * 1.0036;
                investimento_inicial *= 1.0036;
                Console.WriteLine("Após " + contador_mes + " meses, você terá R$" + investimento_inicial);

            }

            Console.WriteLine("Pressione ENTER para finalizar execução . . .");
            Console.ReadLine();
        }
    }
}
