using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9 - Switch");
            int mes = 15;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("JANEIRO");
                    break;
                case 2:
                    Console.WriteLine("FEVEREIRO");
                    break;
                case 3:
                    Console.WriteLine("MARÇO");
                    break;
                case 4:
                    Console.WriteLine("ABRIL");
                    break;
                case 5:
                    Console.WriteLine("MAIO");
                    break;
                case 6:
                    Console.WriteLine("JUNHO");
                    break;
                case 7:
                    Console.WriteLine("JULHO");
                    break;
                case 8:
                    Console.WriteLine("AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("SETEMBRO");
                    break;
                case 10:
                    Console.WriteLine("OUTUBRO");
                    break;
                case 11:
                    Console.WriteLine("NOVEMBRO");
                    break;
                case 12:
                    Console.WriteLine("DEZEMBRO");
                    break;
                default:
                    Console.WriteLine("MÊS INVÁLIDO");
                    break;
            }

            Console.WriteLine("Tecle ENTER para finalizar a execução . . .");
            Console.ReadLine();
        }
    }
}
