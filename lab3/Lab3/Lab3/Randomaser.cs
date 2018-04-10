namespace Lab3
{
    public class Randomaser
    {
        public int[] random(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) array[i] = array[i] * 3;
                else array[i] = 0;
            }
            return array;
        }
    }
}
