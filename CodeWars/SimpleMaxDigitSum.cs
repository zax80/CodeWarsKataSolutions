namespace CodeWars
{
    public static class SimpleMaxDigitSum
    {
        public static long Solve(long n)
        {
            // initializing b as 1 and
            // initial max sum to be of n
            long b = 1, ans = n;

            // iterates from right to
            // left in a digit
            while (n != 0)
            {
                // while iterating this
                // is the number from
                // from right to left
                long cur = (n - 1) * b + (b - 1);

                // calls the function to
                // check if sum of cur is
                // more then of ans
                if (SumOfDigits(cur) > SumOfDigits(ans) ||
                   (SumOfDigits(cur) == SumOfDigits(ans) &&
                                                cur > ans))
                    ans = cur;

                // reduces the number to one unit less
                n /= 10;
                b *= 10;
            }

            return ans;
        }

        // function to calculate the
        // sum of digits of a number.
        private static long SumOfDigits(long a)
        {
            long sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
    }
}