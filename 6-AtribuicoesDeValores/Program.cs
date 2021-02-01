using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições de Valores");
            int idade = 19;
            int idade_aluno = idade;

            //perceba que idade_aluno recebe o valor de idade 
            Console.WriteLine(idade);
            Console.WriteLine(idade_aluno);

            //perceba que se mudarmos o valor de idade, a variavel idade_aluno n será alterada pois uma variavel guarda valor e não referencia 
            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idade_aluno);




            Console.WriteLine("Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
