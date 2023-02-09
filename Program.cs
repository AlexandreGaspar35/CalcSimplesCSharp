// See https://aka.ms/new-console-template for more information
using System;

namespace MinhaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCalc();

        }
        static void MenuCalc()
        {
            Console.Clear();
            Console.WriteLine("O que Deseja Fazer?!");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------");
            Console.WriteLine("Selecione uma Opção: ");

            double result = Convert.ToDouble(Console.ReadLine());

            switch (result)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: MenuCalc(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite um Número:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro Número");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double result = valor1 + valor2;

            Console.WriteLine($"A soma entre {valor1} e {valor2} é = {result}");
            Console.ReadKey();
            MenuCalc();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Número:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro Número");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double result = valor1 - valor2;

            Console.WriteLine($"A Subtração entre {valor1} e {valor2} é = {result}");
            Console.ReadKey();
            MenuCalc();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Número:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro Número");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double result = valor1 * valor2;

            Console.WriteLine($"A Multiplicação entre {valor1} e {valor2} é = {result}");
            Console.ReadKey();
            MenuCalc();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Número:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro Número");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double result = valor1 / valor2;

            Console.WriteLine($"A Divisão entre {valor1} e {valor2} é = {result}");
            Console.ReadKey();
            MenuCalc();
        }
    }
}

