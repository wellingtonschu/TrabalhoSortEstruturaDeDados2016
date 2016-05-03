using System;

namespace Sort
{
    class bubbleSort
    {
        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int auxiliar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = auxiliar;
                    }
                }
                Console.WriteLine("Após passo " + (i + 1));
                Console.WriteLine("[" + String.Join(" ", array) + "]");
            }
        }
    }
}
