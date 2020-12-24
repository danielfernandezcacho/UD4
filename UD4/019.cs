using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _019
    {
        static void Main(string[] args)
        {
            int num = 1;


            while (num <= 100)
            {
                if (num % 2 == 0 || num % 3 == 0)
                {
                    Console.WriteLine(num);
                }

                num++;
            }
        } 
    }

}
