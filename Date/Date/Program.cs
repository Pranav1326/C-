using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of days: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int week; 
            float month, year;
            week = day / 7;
            month = (float)day / 30;
            year = (float)day / 365;

            Console.WriteLine("Days : " + day);
            Console.WriteLine("Weeks : " + week);
            Console.WriteLine("Months : " + month);
            Console.WriteLine("Year : " + year);
            Console.Read();
        }
    }
}
