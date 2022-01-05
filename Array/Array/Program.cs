// Program of using Array to find maximum numbers.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Array // Note: actual namespace depends on the project name.
{
    public class Program
    {
        // Static function for input
        static int input(int o)
        {
            int n;
            Console.WriteLine("Enter number-" + o + " : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Please enter a valid number!");
                input(o);
            }
            return n;
        }

        // Function to reverse elements of an array

        static int[] reverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            int j = 0;
            for (int i = (arr.Length-1); i >= 0; i--)
            {
                reversedArray[j] = arr[i];
                j++;
            }
            return reversedArray;
        }

        // Function to find element's position and index in an array
        static int findNumber(int[] arr, int num)
        {
            int index = -1,i;
            for(i=0; i<arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i;
                }
            }
            if (i > arr.Length)
            {
                return -1;
            }
            return index;
        }

        // Function to find maximum number from an array
        static int findMaxNumber (int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        // Function to find minimum number from an array
        static int findMinNumber (int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        // Function to make sum of all the values in array
        static int totalOfElements(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            // var for defining size of an array
            int sizeOfArray;
            Console.Write("Enter size of Array in number: ");
            sizeOfArray = Convert.ToInt32(Console.ReadLine());

            // Declaring an array
            int[] numbers = new int[sizeOfArray];

            // For loop for taking values of an array from user
            for (int i = 0; i < sizeOfArray; i++)
            {
                int temp = i;
                numbers[i] = input(++temp);
            }

            // Max number of an array
            int maxNumber = findMaxNumber(numbers);
            Console.WriteLine("Max number from array is : " + maxNumber);

            // Min number of an array
            int minNumber = findMinNumber(numbers);
            Console.WriteLine("Min number from array is : " + minNumber);

            // Sum of all the elements of an array
            int sum = totalOfElements(numbers);
            Console.WriteLine("Sum of all elements of array is : " + sum);

            // Print an array
            Console.WriteLine("Array : ");
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }

            // New line
            Console.WriteLine();

            // User input of number to find it in an array
            Console.WriteLine("Enter a number to find it's index in an array: ");
            int findNum = Convert.ToInt32(Console.ReadLine());

            int ans = findNumber(numbers, findNum);
            if(ans == -1)
            {
                Console.WriteLine("Element not found!");
            }
            else
            {
                Console.WriteLine(ans + " is the index of number " + findNum);
                Console.WriteLine(++ans + " is the position of number " + findNum);
            }

            // Reverse of an array
            int[] revArray = reverseArray(numbers);
            Console.Write("Reversed Array : ");
            for(int k=0; k<revArray.Length; k++)
            {
                Console.Write(revArray[k] + " ");
            }

            // To hold the output
            Console.ReadLine();
        }
    }
}