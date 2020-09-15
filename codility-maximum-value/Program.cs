using System;

namespace codility_maximum_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Happy World!");
        }
    }

    class Solution
    {
        public int solution(int num)
        {
            // digit to insert in given number
            int digit = 5;

            // edge case
            if (num == 0)
            {
                return digit * 10;
            }

            // -1 if num is negative number else 1
            int negative = num / Math.Abs(num);
            // get the absolute value of given number
            num = Math.Abs(num);
            int n = num;
            // maximum number obtained after inserting digit.
            int maxValue = int.MinValue;
            int counter = 0;
            int position = 1;

            // count the number of digits in the given number.
            while (n > 0)
            {
                counter++;
                n = n / 10;
            }

            // loop to place digit at every possible position in the number,
            // and check the obtained value.
            for (int i = 0; i <= counter; i++)
            {
                int newValue = ((num / position) * (position * 10)) + (digit * position) + (num % position);

                // if new value is greater the maxValue
                if (newValue * negative > maxValue)
                {
                    maxValue = newValue * negative;
                }

                position = position * 10;
            }

            return maxValue;
        }
    }
}
