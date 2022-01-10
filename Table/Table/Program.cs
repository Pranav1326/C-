using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        // Multiplication table printing function
        static void printTable(int n)
        {
            if (n >= 9) {
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j + " * " + i + " = " + (j * i) + "\t");
                }
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
            printTable(number);
        }
    }
}