﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Table
{
    class Program
    {
        static void table(int n) {
            for (int i = 1; i <= 10; i++) {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j + " * " + i + " = " + (j * i) + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            table(number);
            Console.Read();
        }
    }
}
