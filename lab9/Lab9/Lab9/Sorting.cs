using System;

class Sorting
{
    private int[,] array;
    private int[] newArray = new int[9];
    public Sorting(int[,] beginArray)
    {
        array = beginArray;
    }

    public void FormatinArray()
    {
        int k = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[k] = array[i, j];
                k++;
            }
        }
        Array.Sort(newArray);
    }

    public void SortingNewArray()
    {
        this.FormatinArray();
        int z = 0;
        for (int i = 2; i >= 0; i--)
        {
            for (int j = 2; j >= 0; j--)
            {
                array[i, j] = newArray[z];
                z++;
            }
        }
    }

    public int[,] getArray()
    {
        return this.array;
    }
}