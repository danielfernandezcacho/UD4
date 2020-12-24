using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _023
    {
        static void Main(string[] args)
        {
            double numero1;
            double nuemro2;
            double resultado = 0;

           
             Console.WriteLine("Escribe el num 1");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el codigo de operacion");
            String operacion = Console.ReadLine();

             Console.WriteLine("Escribe el num 2");
             nuemro2 = Convert.ToDouble(Console.ReadLine());

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + nuemro2;
                    break;
                case "-":
                    resultado = numero1 - nuemro2;
                    break;
                case "*":
                    resultado = numero1 * nuemro2;
                    break;
                case "/":
                    resultado = numero1 / nuemro2;
                    break;
                case "%":
                    resultado = numero1 % nuemro2;
                    break;
            }

             Console.WriteLine(numero1 + " " + operacion + " " + nuemro2 + " = " + resultado);

        }
    }
   
}

