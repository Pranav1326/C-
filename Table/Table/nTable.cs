using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Table
{
    class nTable
    {
        static void printTable(int n) {
            if(n > 0) {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n + " * " + i + " = " + n * i);
                }
                Console.WriteLine();
                printTable(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            printTable(number);
            Console.Read();
        }
    }
}
