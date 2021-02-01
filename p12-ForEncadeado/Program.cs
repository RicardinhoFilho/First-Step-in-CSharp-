using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - For encadeado");
            //Neste exercicio queremos escrever as estrelas dessa forma
            //*
            //**
            //***
            //****
            //*****

            //exemplo utilizando break
            for (int linha = 0; linha <= 10; linha++)
            {
                for (int coluna = 0; coluna <= 10; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)//quando temos apenas uma instrução para o "if" não precisamos utilizar "{}"
                        break;//utilizamos break para parar a execução do laço
                }
                Console.WriteLine();
            }

            //mesmo efeito, entretanto sem utilizarmos "break"
            for (int linha = 0; linha <= 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)//quando temos apenas uma instrução para o "for" não precisamos utilizar "{}"
                    Console.Write("*");
                   
                Console.WriteLine();
            }
            Console.WriteLine("Pressione ENTER para finalizar execução . . .");
            Console.ReadLine();
        }
    }
}
