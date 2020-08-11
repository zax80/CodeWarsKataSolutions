using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class Dubstep
    {
        public static string SongDecoder(string input)
        {
            // I like to use ' Regex.Replace(myString, @"\s+", " ") ' to catch any whitespaces and replace them with a single
            return Regex.Replace(input.Replace("WUB", " ").TrimStart().TrimEnd(), @"\s+", " ");
        }
    }
}