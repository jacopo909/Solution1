using System;

namespace ConsoleApp1
{
    internal class Bubblesort
    {
        internal static void Sort(int[] array)
        {
            int x;
            int y;
            int temp;
            for (x = 0; x < array.Length - 1; x++)
            {
                for (y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y] = temp;
                    }
                }
            }
        }
    }
}