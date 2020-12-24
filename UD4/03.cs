using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _03
    {
        static void Main(string[] args)
        {
            String nombre;
            String años;
            int anyos=0;


            Console.WriteLine("Escribe tu edat");
            años = Console.ReadLine();
            anyos = Convert.ToInt32(años);

            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("hola " + nombre + " tu edat es " + años);
        }
    }
}
