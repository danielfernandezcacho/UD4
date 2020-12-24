using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _021
    {
        static void Main(string[] args)
        {
            string diadesemana;

            Console.WriteLine("Escribe que dia de la semana es");
            diadesemana = Console.ReadLine();

            switch (diadesemana.ToLower())
            {

                case "lunes":

                case "martes":

                case "miercoles":

                case "jueves":

                case "viernes":
                    Console.WriteLine("Es dia laborable");
                    break;
                case "sabado":

                case "domingo":
                    Console.WriteLine("es dia no laboral ");
                    break;
                default:
                    Console.WriteLine("Ese dia no es correcto");
                    break;
            }


            Console.ReadLine();
        }
    }
}
