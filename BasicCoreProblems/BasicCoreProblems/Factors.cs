using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems
{
    public class Factors
    {
        public void Calculation()
        {
            Console.WriteLine("Enter the Number to Calculate Prime Factorization");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    int count = 0;
                    while (num % i == 0)
                    {
                        num /= i;
                        count++;
                    }
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
