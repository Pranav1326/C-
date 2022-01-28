using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Alphabet
    {
        static char input() {
            char chr = '0';
            try
            {
                Console.Write("Enter a character: ");
                chr = Convert.ToChar(Console.ReadLine());
                return chr;
            }
            catch
            {
                Console.WriteLine("Please enter a valid single character.");
            }
            return chr;
        }
        static void Main(string[] args) {
            char chr = input();
            int n = chr;

            Console.WriteLine("ASCII code: " + n);

            if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
            {
                if (n == 97 || n == 65 || n == 69 || n == 101 || n == 73 || n == 105 || n == 79 || n == 111 || n == 85 || n == 117)
                {
                    Console.WriteLine(chr + " is vowel");
                }
                else
                {
                    Console.WriteLine(chr + " is constant.");
                }
            }
            else {
                Console.WriteLine(chr + " is a special character.");
            }
            
            Console.Read();
        }
    }
}
