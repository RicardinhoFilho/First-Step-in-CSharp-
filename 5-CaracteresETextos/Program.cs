using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4 - Caracteres e Textos");

            //a variavel de tipo char armazena somente 1 simbolo e temos que colocar o símbolo entre '' 
            char caractere = 'a';
            Console.WriteLine(caractere);
            //neste exemplo abaixo estamos pegando o caractere localizado na posição 65 da tabela assci
            caractere = (char)65;
            Console.WriteLine(caractere);
            //neste exemplo abaixo estamos pegando o próximo caractere seguindo a tabela assci
            caractere = (char)(caractere + 1);
            Console.WriteLine(caractere);

            //Utilizamos a variavel do tipo string para escrevermos uma cadeia de caracteres que escrevemos dentro de ""
            string tentativa_titulo = "CURSOS ALURA: -.NET -JAVA -JAVASCRIPT";
            Console.WriteLine(tentativa_titulo);
            //Neste exemplo abaixo estamos escrevendo a mesma variavel de outra forma possivel
            tentativa_titulo = "CURSOS ALURA: " +
                "-.NET" +
                "-JAVA" +
                "-JAVASCRIPT";
            Console.WriteLine(tentativa_titulo);
            //neste exemplo estamos escrevendo a mesma váriavel entretanto em forma de lista utilizando "@" antes da variavel em si
            tentativa_titulo = tentativa_titulo = @"CURSOS ALURA: 
                -.NET
                -JAVA
                -JAVASCRIPT";
            //percebam a diferença desta reescrita abaixo
            Console.WriteLine(tentativa_titulo);
            tentativa_titulo = tentativa_titulo = @"CURSOS ALURA: 
  -.NET
 -JAVA
-JAVASCRIPT";
            Console.WriteLine(tentativa_titulo);

            Console.WriteLine("Pressione ENTER para finalizar . . .");
            Console.ReadLine();

        }
    }
}
