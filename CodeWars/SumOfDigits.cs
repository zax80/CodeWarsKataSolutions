using System;

namespace CodeWars
{
    public static class SumOfDigits
    {
        public static int DigitalRoot(long n)
        {
            string s = n.ToString();
            int result = Recursion(s);

            return result;
        }

        private static int Recursion(string s)
        {
            int result = 0;

            foreach (char c in s)
                result += Int32.Parse(c.ToString());

            return (result > 9) ? Recursion(result.ToString()) : result;
        }
    }
}