using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems
{
    public class LargestNumber
    {
        public void Largest()
        {
            Console.WriteLine("Enter the First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number :");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine("{0} is the Largest number", firstNumber);
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                Console.WriteLine("{0} is the Largest number", secondNumber);
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                Console.WriteLine("{0} is the Largest number", thirdNumber);
            else
                Console.WriteLine("The Three numbers are equal");
        }
    }
}
