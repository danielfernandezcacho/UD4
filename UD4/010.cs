using System;
using System.Collections.Generic;
using System.Text;

namespace UD4
{
    class _010
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
