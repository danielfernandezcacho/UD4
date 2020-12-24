using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _022
    {
        static void Main(string[] args)
        {
            String contraseña = "hola";
            int INTENTOS = 3;
            Boolean acierto = false;


            String password;
            for (int i = 0; i < 3 && !acierto; i++)
            {
                Console.WriteLine("Introduce una contraseña");
                password = Console.ReadLine();

                if (password.Equals(contraseña))
                {
                    acierto = true;
                    Console.WriteLine("Enhorabuena, acertaste");

                }
                else if (password!=contraseña);
                {
                    Console.WriteLine("Fallaste");
                }

            }
        }
    }
}
