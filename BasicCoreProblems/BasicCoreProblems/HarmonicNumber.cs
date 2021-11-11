using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter the last harmonic number");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicSum = 0;
            for (double i = 1; i <= num; i++)
            {
                Console.WriteLine("1/" + i + "=" + (1 / i));
                harmonicSum += (1 / i);
            }
            Console.WriteLine("The Sum of harmonic number is :" + harmonicSum);
        }
    }
}
