using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _016
    {
        static void Main(string[] args)
        {
            double precio,iva=0.21, precioFinal;

             Console.WriteLine("Introduce el numero");
             precio = Convert.ToDouble(Console.ReadLine());

            precioFinal = precio + (precio * iva);
            Console.WriteLine(precio);

        }
    }
}
