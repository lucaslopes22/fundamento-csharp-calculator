using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Seleciona as opções da calculadora: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("--------------");
            Console.Write("Opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao){
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }
        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 / num2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
