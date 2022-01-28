using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class SecondLargestElement
    {
        static void Main(string[] args) {
            int[] numbers = new int[5]; 
            Console.WriteLine("Enter 5 Elements of an numbersay: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Element-" + numbers[i] + " = ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int j = 0; j <= numbers.Length - 2; j++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            Console.WriteLine("Second Largest Number: " + numbers[numbers.Length-2]);
            Console.Read();
        }
    }
}
