using System.Collections.Generic;

namespace Lab3
{
    public class Randomaser
    {
        public List<int> FindEven(int[] array)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                     result.Add(array[i]);
                }
            }
          
            return result;
        }

        public List<int> FindOdd(int[] array)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result.Add(array[i]);
                }
            }
            return result;
        }
    }
}
