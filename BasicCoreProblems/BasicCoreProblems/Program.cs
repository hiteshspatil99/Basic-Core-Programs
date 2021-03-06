using System;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. Flip Coin \n 2. Leap Year \n 3. Power of Two \n 4. Harmonic Number \n 5. Factors \n 6.Quotient Remainder \n 7. SwapTwoNumers \n 8. Even Or Odd Number \n 9.Vowel Or Consonent \n 10.Largest Number \n 11. Exit");
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
                        Factors fc = new Factors();
                        fc.Calculation();
                        break;
                    case 6:
                        QuotientRemainder result = new QuotientRemainder();
                        result.Division();
                        break;
                    case 7:
                        SwappingNumbers ans = new SwappingNumbers();
                        ans.Swap();
                        break;
                    case 8:
                        EvenOrOdd num = new EvenOrOdd();
                        num.EvenOdd();
                        break;
                    case 9:
                        VowelOrConsonant letter = new VowelOrConsonant();
                        letter.Alphabet();
                        break;
                    case 10:
                        LargestNumber max = new LargestNumber();
                        max.Largest();
                        break;
                    case 11:
                        flag = false;
                        break;

                }
            }
        }
    }
}   
