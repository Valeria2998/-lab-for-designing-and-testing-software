namespace Lab4
{
    public class Swapper
    {
        public int[] Swap(int[] array)
        {
            int minIndex = 0, maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                else if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            if (minIndex > maxIndex)
            {
                Swap(ref minIndex, ref maxIndex);
            }

            for (int i = minIndex + 1, j = maxIndex - 1; i < j; i++, j--)
            {
                Swap(ref array[i], ref array[j]);
            }

            return array;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
