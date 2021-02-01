using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoEOutrosTiposDeVariaveisNumericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4 - Conversão e Outros Tipos de Variaveis Numericas");
           
            double salario = 19000.75;
            Console.WriteLine(salario);
            //int é um número de no maximo 32bits
            //como vemos no exemplo abaixo podemos forçar a transformação de um double para int 
            int salario_inteiro = (int)salario;
            Console.WriteLine(salario_inteiro);

            //para utilizarmos float precisamos especificar terminando o número com a letra f
            float ponto_flutuante = 5.5f;
            Console.WriteLine(ponto_flutuante);

            //long armazena números de 32bits
            long idade_da_terra = 130000000000000;
            Console.WriteLine(idade_da_terra);

            //short armazena 16bits
            short idade_pessoa = 65;
            Console.WriteLine(idade_pessoa);

            Console.WriteLine("Tecle enter para encerrar . . . ");
            Console.ReadLine();
        }
    }
}
