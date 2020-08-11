namespace CodeWars
{
    public static class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] result = new double[n];
            int index = 0;
            while (index <= n - 1)
            {         
                result[index] = index <= 2 ?signature[index] :
                    (double)(result[index - 1] + result[index - 2] + result[index - 3]);
                index++;
            }

            return result;
        }
    }
}