using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_VariaveisBooleanas
{
    

    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Projeto 8 - Variaveis Booleanas");
                int idade = 15;
                int quantidade_de_pessoas = 1;
                bool pode_entrar = idade > 18 || quantidade_de_pessoas > 1;

                if (pode_entrar)
                {
                    Console.WriteLine("Entrada Permitida");
                }
                else
                {
                    Console.WriteLine("Entrada Proibida");
                }

                Console.WriteLine("Tecle ENTER para finalizar execução . . .");
                Console.ReadLine();
            }
        }
    }
