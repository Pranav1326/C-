using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern1.cs
{
    class Pattern2
    {
        static void Main(string[] args) {
            for (int i = 1; i <= 5; i++)
            {
                char c = 'a';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c + " ");
                    c++;
                }
                Console.WriteLine();
            }
            Console.Read();    
        }
    }
}
