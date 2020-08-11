namespace CodeWars
{
    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            string result = "";
            int i = 0;
            foreach (char c in text)
            {
                i++;
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    result += ((int)c % 32).ToString() + " ";
                }
            }
            return result.TrimEnd();
        }
    }
}