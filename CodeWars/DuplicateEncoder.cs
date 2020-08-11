namespace CodeWars
{
    public static class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            string result = "";
            foreach (char c in word)
            {
                result += (CharCount(c, word) == 1) ? "(" : ")";
            }
            return result;
        }

        private static int CharCount(char ch, string word)
        {
            int cnt = 0;
            foreach (char c in word)
                if (ch.ToString().ToUpper() == c.ToString().ToUpper())
                    cnt++;
            return cnt;
        }
    }
}