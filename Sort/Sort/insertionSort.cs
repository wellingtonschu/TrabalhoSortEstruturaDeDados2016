namespace Sort
{
    class insertionSort
    {
        public void InsertionSort(int[] array)
        {
            int N = array.Length;
            for (int i = 1; i < N; i++)
            {
                int j = i - 1;
                int temp = array[i];

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--; ;
                }
                array[j + 1] = temp;
            }
        }
    }
}
