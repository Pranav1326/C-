using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Note
    {
        static void Main(string[] args) {
            Console.Write("Enter no: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] counter = new int[10];
            for (int i = 0; i < counter.Length; i++) {
                counter[i] = 0;
            }
            while (num != 0)
            {
                if (num >= 2000)
                {
                    num -= 2000;
                    counter[0]++;
                }
                if (num >= 500)
                {
                    num -= 500;
                    counter[1]++;
                }
                if (num >= 200)
                {
                    num -= 200;
                    counter[2]++;
                }
                if (num >= 100)
                {
                    num -= 100;
                    counter[3]++;
                }
                if (num >= 50)
                {
                    num -= 50;
                    counter[4]++;
                }
                if (num >= 20)
                {
                    num -= 20;
                    counter[5]++;
                }
                if (num >= 10)
                {
                    num -= 10;
                    counter[6]++;
                }
                if (num >= 5)
                {
                    num -= 5;
                    counter[7]++;
                }
                if (num >= 2)
                {
                    num -= 2;
                    counter[8]++;
                }
                if (num >= 1)
                {
                    num -= 1;
                    counter[9]++;
                }
            }
            for (int i = 0; i < counter.Length; i++ )
            {
                if (counter[i] != 0) {
                    Console.WriteLine(notes[i] + " Rs note " + counter[i] + " times.");     
                }
            }
            Console.Read();
        }
    }
}
