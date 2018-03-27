namespace Lab1
{
    class DigitsAnalyser
    {
        public int SplitNumber1(int number)
        {
            int[] result = new int[4];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = number % 10;
                number /= 10;
            }
            int summ = result[0] + result[1] + result[2] + result[3];
            return summ;
        }

        public int SplitNumber2(int number)
        {
            int[] result = new int[4];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = number % 10;
                number /= 10;
            }
            int summ = result[0] * result[1] * result[2] * result[3];
            return summ;
        }

    }
}
