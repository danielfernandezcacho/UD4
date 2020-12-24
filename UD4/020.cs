using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _020
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Introduce el número de ventas");
             int numVentas = Convert.ToInt32(Console.ReadLine());


            int sumaVentas = 0;
            for (int i = 0; i < numVentas; i++)
            {
                //indico el numero de venta
                 Console.WriteLine("Introduce el precio de la venta " + (i + 1));
                int venta = Convert.ToInt32(Console.ReadLine());

                sumaVentas = sumaVentas + venta;
            }

             Console.WriteLine(sumaVentas);
        }
    }
}
