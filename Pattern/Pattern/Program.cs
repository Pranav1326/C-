﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while(i >= 1) {
                int j = 5;
                while(j >= i) {
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
