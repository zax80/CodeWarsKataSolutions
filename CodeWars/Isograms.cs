using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class Isograms
    {
        public static bool IsIsogram(string str)
        {
            bool result = true;
            if (String.IsNullOrEmpty(str))
                result = str != null;

            if (Regex.IsMatch(str, @"^[a-zA-Z]+$"))
            {
                string duplicateChars = "";
                str = str.ToUpper();
                foreach (char c in str)
                {
                    if (!duplicateChars.Contains(c))
                    {
                        duplicateChars += c;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}