using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
