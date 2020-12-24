using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _05
    {
        static void Main(string[] args)
        {
            string diadesemana;

            Console.WriteLine("Escribe que dia de la semana es");
            diadesemana = Console.ReadLine();

            switch (diadesemana.ToLower())
            {

                case "lunes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                    Console.WriteLine("Es fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("Ese dia no es correcto");
                    break;
            }


            Console.ReadLine();
        }
    }  
}
