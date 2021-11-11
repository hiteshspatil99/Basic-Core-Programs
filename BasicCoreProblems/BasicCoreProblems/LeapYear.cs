using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }

    }
}
