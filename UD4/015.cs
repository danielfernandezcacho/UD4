using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _015
    {
        static void Main(string[] args)
        {
            double radio;

            Console.WriteLine("Introduce un radio");
            radio = Console.ReadLine();
            double area = Math.PI * Math.pow(radio, 2);

         Console.WriteLine("El area del circulo es "+area);
    }
}
}
