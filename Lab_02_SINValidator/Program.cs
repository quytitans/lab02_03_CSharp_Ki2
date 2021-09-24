using System;
using System.Collections.Generic;
using System.Linq;

namespace SINValidator
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter SIN: ");
            var Sin = Int32.Parse(Console.ReadLine());
            if (IsCanadianSocialInsuranceNumber(Sin))
            {
                Console.WriteLine("This is a valid SIN");
            }
            else
            {
                Console.WriteLine("This is a invalid SIN");
            }
        }
        public static IEnumerable<int> ToDigitEnumerable(this int number)
        {
            IList<int> digits = new List<int>();

            while(number > 0)
            {
                digits.Add(number%10);
                number = number/10;
            }
            return digits.Reverse();
        }

        public static bool IsCanadianSocialInsuranceNumber(int number)
        {
            var digits = number.ToDigitEnumerable();
            if (digits.Count() != 9) return false;
            var total = digits.Where((value, index) => index%2 == 0 && index != 8).Sum()
                        + digits.Where((value, index) => index%2 != 0).Select(v => v*2)
                            .SelectMany(v => v.ToDigitEnumerable()).Sum();
            var checkDigit = (10 - (total%10)) % 10;
            return digits.Last() == checkDigit;
        }
    }
}