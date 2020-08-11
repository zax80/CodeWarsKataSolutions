namespace CodeWars
{
    public static class OnesAndZeros
    {
        public static int BinaryArrayToNumber(int[] BinaryArray)
        {
            int v = 8;
            int result = 0;
            foreach (int i in BinaryArray)
            {
                if (i == 1)
                    result += v;
                v /= 2;
            }

            return result;
        }
    }
}