using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _015
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Introduce un numero");
            int numero = Int32.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es divisible entre 2");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " no es divisible entre 2");
            }
        }
    }
}
