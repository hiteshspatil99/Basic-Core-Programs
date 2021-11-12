using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems
{
    public class QuotientRemainder
    {
        public void Division()
        {
            Console.WriteLine("Enter the Dividend");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }

}
