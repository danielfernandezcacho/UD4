using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _015
    {
        static void Main(string[] args)
        {
            double area, radi;
            Console.WriteLine("Dime el radio");
            radi = Double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(radi, 2);

            Console.WriteLine("El área es: " + area);
        }
}
}
