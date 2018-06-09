using System.Collections.Generic;

namespace lab8
{
    class AddToAnArray
    {
        

        private int SumOfPositive(int i, List<List<int>> oldArray)
        {
            List<List<int>> array = new List<List<int>>();
            array = oldArray;
            int sum = 0;
            for (int j = 0; j < array[i].Count; j++)
            {
                if (array[i][j] > 0)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

        public List<int> Add(List<List<int>> array)
        {

            List<int> newArray = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                int sum = SumOfPositive(i,array);
                for (int j = 0; j < array[i].Count; j++)
                {
                    if (array[i][j] < 0)
                    {
                        newArray.Add(sum);
                    }
                }
            }
            return newArray;
        }
    }
}
