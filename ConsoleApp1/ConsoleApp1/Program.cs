using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static int input(int o)
        {
            int n;
            Console.WriteLine("Please Enter Number-" + o + ": ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n<0 || n>100)
            {
                Console.WriteLine("Wrong Input! Try again.");
                n = input(o);
            }
            return n;
        }
        static int menu()
        {
            int n;
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Enter elements of array");
            Console.WriteLine("2. Display Input");
            Console.WriteLine("3. Search an element in array");
            Console.WriteLine("0. Exit");
            n = input(1);
            return n;
        }
        static void findNumber(int[] arr, int n)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Index of " + n + " is " + i);
                    break;
                }
            }
            if (i==arr.Length)
            {
                Console.WriteLine("Element not Found!");
            }
        }
        public static void Main(string[] args)
        {
            int inputNumber;
            int[] numbers = new int[10];
            inputNumber = menu();
            while (inputNumber != 0)
            {
                switch (inputNumber)
                {
                    case 1:
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = input(i);
                        }
                        Console.ReadLine();
                        inputNumber = menu();
                        break;
                    case 2:
                        Console.Clear();
                        foreach (int n in numbers)
                        {
                            Console.WriteLine(n);
                        }
                        Console.ReadLine();
                        inputNumber = menu();
                        break;
                    case 3:
                        int noToFind = input(1);
                        findNumber(numbers, noToFind);
                        Console.ReadLine();
                        inputNumber = menu();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice.");
                        Console.ReadLine();
                        inputNumber = menu();
                        break;
                }
            }
        }
    }
}