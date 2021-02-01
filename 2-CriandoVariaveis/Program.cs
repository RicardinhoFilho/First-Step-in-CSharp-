using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando programa 2 - Criando Variaveis");

            int idade;

            idade = 32;

            Console.WriteLine("idade");

            Console.WriteLine(idade);

            idade = 15;
            Console.WriteLine(idade);

            idade = 15 + 5;
            Console.WriteLine(idade);

            idade = 15 + 5 * 5;
            Console.WriteLine(idade);

            idade = (15 + 5) * 5;
            Console.WriteLine(idade);
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("Tecle ENTER para finalizar . . .");
            Console.ReadLine();
        }
    }
}
