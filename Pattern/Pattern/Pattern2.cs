using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            int i = 15;
            while (i >= 11)
            {
                int j = 15;
                while (j >= i)
                {
                    Console.Write(j + " ");
                    j--;
                }
                Console.WriteLine();
                i--;
            }
            Console.Read();
        }
    }
}
