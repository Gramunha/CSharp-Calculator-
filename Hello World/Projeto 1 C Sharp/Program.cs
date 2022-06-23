using System;

namespace Projeto_1_C_Sharp
{
    internal class Program
    {
        private static object result;

        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double resoult = 0;

            Console.WriteLine("-------------------");
            Console.WriteLine("----CALCULADORA----");
            Console.WriteLine("-------------------");

            Console.Write("Coloca o primeiro numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Coloca o segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolhe o tipo de conta: ");
            Console.WriteLine("\t+ : Adicionar");
            Console.WriteLine("\t- : Subtrair");
            Console.WriteLine("\t* : Multiplicar");
            Console.WriteLine("\t/ : Dividir");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Resultado : {num1} + {num2} = " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Resultado : {num1} - {num2} = " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Resultado : {num1} * {num2} = " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Resultado : {num1} / {num2} = " + result);
                    break;

            }
            Console.ReadKey();
        }

    }
}
