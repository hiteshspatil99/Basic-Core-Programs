using System;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. Flip Coin \n 2. Leap Year \n 3. Power of Two \n 4. Harmonic Number \n 5. Factors \n 6. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        FlipCoin coin = new FlipCoin();
                        coin.Play();
                        break;
                    case 2:
                        LeapYear check = new LeapYear();
                        check.Leap();
                        break;
                    case 3:
                        PowerOfTwo res = new PowerOfTwo();
                        res.Power();
                        break;

                    case 4:
                        HarmonicNumber sum = new HarmonicNumber();
                        sum.Harmonic();
                        break;

                    case 5:
                        Factorial.Factorization();
                        break;
                    case 6:
                        QuotientRemainder result = new QuotientRemainder();
                        result.Division();
                        break;
                    case 7:
                        flag = false;
                        break;

                }
            }
        }

        
