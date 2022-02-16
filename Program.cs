﻿// See https://aka.ms/new-console-template for more information

using System;

namespace AppCalculatorBaltaio // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine(" { O que deseja fazer?");
            Console.WriteLine(" { 1 - Soma");
            Console.WriteLine(" { 2 - Subtração");
            Console.WriteLine(" { 3 - Divisão");
            Console.WriteLine(" { 4 - Multiplicação");
            Console.WriteLine(" { 5 - Sair");

            Console.WriteLine(" {--------------------}");
            Console.WriteLine(" { Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break; 
            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("  Função SOMA selecionada ");
            Console.WriteLine("");

            Console.WriteLine("  Digite o Primeiro valor:  ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("  Digite o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            // float e parse para converter o valor.

            Console.WriteLine(""); // Pular uma linha somente

            float resultado = v1 + v2;
            //Console.WriteLine("O resultado da soma é " + resultado);

            Console.WriteLine("  Primeiro valor  " + v1);
            Console.WriteLine("  Primeiro valor  " + v2);
            Console.WriteLine("");
            Console.WriteLine($"  O resultado da soma é {resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            //Console.WriteLine("O resultado da soma é " + (v1 + v2));

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("  Função SUBTRAÇÃO selecionada ");
            Console.WriteLine("");

            Console.WriteLine("  Digite o Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("  Digite o Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("  Primeiro valor  " + v1);
            Console.WriteLine("  Primeiro valor  " + v2);
            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"  O resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("  Função DIVISÃO selecionada ");
            Console.WriteLine("");

            Console.WriteLine("  Digite o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("  Digite o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("  Primeiro valor  " + v1);
            Console.WriteLine("  Primeiro valor  " + v2);
            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"  O resultado da Divisão é: {resultado}");

            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("  Função MULTIPLICAÇÃO selecionada ");
            Console.WriteLine("");

            Console.WriteLine("  Digite o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("  Digite o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            Console.WriteLine("  Primeiro valor  " + v1);
            Console.WriteLine("  Primeiro valor  " + v2);
            Console.WriteLine("");
            //float resultado = v1 * v2;
            Console.WriteLine($"  O resultado da multiplicação é: " + (v1 * v2));

            Console.ReadKey();
            Menu();
        }




    }

    







}



