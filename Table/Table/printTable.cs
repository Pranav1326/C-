using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Table
{
    class printTable
    {
        static void Main(string[] args) 
        {
            int i, j, k, a, r, c;
            int[,] mul = new int[20, 20];
            Console.Clear();
            Console.WriteLine("Enter a number: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            c = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < r; i++) {
                k = 1;
                k = i + 1;
                Console.Write(k);
                for (j = 1; j <= c; j++) {
                    a = j;
                    mul[i, j] = a * k;
                    Console.Write(mul[i,j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
