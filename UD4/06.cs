using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _06
    {
        static void Main(string[] args)
        {
            double preu = 0;
            string forma;
            int numero_cuenta;

            Console.WriteLine("ecriu el preu de el producte");
            preu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escriu si vols pagar amb tarjeta o amb efectiu");
            forma = (Console.ReadLine()).ToLower();

            if (forma.Equals("tarjeta"))
            {

                Console.WriteLine("quin es ul nuemero de la tarjeta");
                numero_cuenta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El producte amb preu " + preu + " ha estat comprat" +
                "amb el numero de compte " + numero_cuenta);


            }
            else if (forma.Equals("efectivo"))
            {

                Console.WriteLine("El producto con precio " + preu + " has pagat");

            }
            else
            {

                Console.WriteLine("la forma de pagament ha sugut correcta");
            }

            Console.ReadLine();
        }
    }
}
