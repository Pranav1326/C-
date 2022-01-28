using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class RevArray
    {
        static void Main(string[] args) {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ogArray = new int[size];

            for (int i = 0; i < ogArray.Length; i++) {
                Console.Write("Element-" + i + " = ");
                ogArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Origional Array: ");
            foreach (int f in ogArray)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();

            int[] rArr = new int[ogArray.Length];

            int temp, counter = (ogArray.Length)-1;

            for (int i = 0; i < ogArray.Length; i++)
            {
                temp = ogArray[i];
                rArr[counter] = temp;
                counter--;
            }
            Console.WriteLine("Reversed Array: ");
            for (int i = 0; i < rArr.Length; i++)
            {
                Console.Write(rArr[i] + " ");
            }

            Console.Read();
        }
    }
}
