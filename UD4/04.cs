using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _04
    {
        static void Main(string[] args)
        {

            string numeros;
            

            Console.WriteLine ("Escribeme el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine ());
 
            Console.WriteLine ("Escribeme el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine ());
 
            if (num1 > num2) {
                Console.WriteLine ("El primer numero es mayor segundo " +num1);
            } else {
                Console.WriteLine ("El segundo numero es mayor que el primero "+num2);
            }
 
            Console.ReadLine ();
        }

    }
 }

