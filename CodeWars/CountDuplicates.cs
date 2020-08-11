using System;
using System.Linq;

namespace CodeWars
{
    public static class CountDuplicates
    {
        public static int Count(string str)
        {
            string duplicateChars = "";

            if (!String.IsNullOrEmpty(str)) // Check for content
            {
                int index = 0;
                str = str.ToUpper(); // Because  string.Contrains is Case Sensitive
                foreach (char c in str) // Loop string characters
                {
                    index++;
                    if (index != str.Length - 1) // Check if it's last char...
                    {
                        string rest = str.Substring(index); // Get rest of string
                        if (!duplicateChars.Contains(c)) // Check if character is in the list of duplicare
                        {
                            if (rest.Contains(c))
                            {
                                duplicateChars += c; // Add to list of duplicate
                            }
                        }
                    }
                }
            }

            return duplicateChars.Length;
        }

        public static int CountLinq(string str)
        {
            return str.GroupBy(char.ToLower).Count(x => x.Count() > 1);
        }
    }
}