namespace Sort
{
    class selectionSort
    {
        public void SelectionSort(int[] array)
        {
            int N = array.Length;

            for (int i = 0; i < N; i++)
            {
                int menor = array[i];
                int posicao = i;

                for (int j = i + 1; j < N; j++)
                {
                    if (array[j] < menor)
                    {
                        menor = array[j];
                        posicao = j;
                    }
                }
                int temp = array[posicao];

                array[posicao] = array[i];
                array[i] = temp;
            }
        }
    }
}
