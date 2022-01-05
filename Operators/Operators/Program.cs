// Program of use of operator using switch case.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Operators // Note: actual namespace depends on the project name.
{
    public class Program
    {
        // Static function for printing menu.
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtracion");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            Console.WriteLine("6. Post-fix Increment");
            Console.WriteLine("7. Per-fix Decrement");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your Choice: ");
            var n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        // Static function for input.
        static int input(int o)
        {
            Console.WriteLine("Enter number-" + o + " : ");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static void Main(string[] args)
        {
            //var Declairation
            int n = menu();
            int num1, num2, ans;

            while (n != 0)
            {
                switch (n){
                    case 0:
                        Console.WriteLine("Exit.");
                        System.Environment.Exit(1);
                        break;
                    case 1:
                        num1 = input(1);
                        num2 = input(2);
                        ans = num1 + num2;
                        Console.WriteLine("Addition is " + ans);
                        Console.ReadLine();
                        n = menu();
                        break;
                    case 2:
                        num1 = input(1);
                        num2 = input(2);
                        ans = num1 - num2;
                        Console.WriteLine("Subtraction is " + ans);
                        Console.ReadLine();
                        n = menu();
                        break;
                    case 3:
                        num1 = input(1);
                        num2 = input(2);
                        ans = num1 * num2;
                        Console.WriteLine("Multiplication is " + ans);
                        Console.ReadLine();
                        n = menu();
                        break;
                    case 4:
                        num1 = input(1);
                        num2 = input(2);
                        ans = num1 / num2;
                        Console.WriteLine("Division is " + ans);
                        Console.ReadLine();
                        n = menu();
                        break;
                    case 5:
                        num1 = input(1);
                        num2 = input(2);
                        ans = num1 % num2;
                        Console.WriteLine("Modulus is " + ans);
                        Console.ReadLine();
                        n = menu();
                        break;
                    case 6:
                        num1 = input(1);
                        Console.WriteLine("Before Post-fix Incrementing value is " + num1);
                        num1++;
                        Console.WriteLine("After Post-fix Incrementing value is " + num1);
                        Console.ReadLine();
                        n = menu();
                        break;
                    case 7:
                        num1 = input(1);
                        Console.WriteLine("Before Pre-fix Decrementing value is " + num1);
                        --num1;
                        Console.WriteLine("After Pre-fix Decrementing value is " + num1);
                        Console.ReadLine();
                        n = menu();
                        break;
                }
            }
        }
    }
}