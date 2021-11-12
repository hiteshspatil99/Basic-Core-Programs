using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems
{
    public class SwappingNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter the First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After Swapping these Two Numbers : First number is =" + firstNumber + " and Second number is =" + secondNumber);
        }
    }
}
