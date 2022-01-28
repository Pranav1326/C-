using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Sum
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int sum = 0, lastNum = 0;
            while (temp != 0) {
                lastNum = temp % 10;
                sum = sum + lastNum;
                temp /= 10;
            }
            Console.WriteLine("Sum is " + sum);
            Console.Read();
        }
    }
}
