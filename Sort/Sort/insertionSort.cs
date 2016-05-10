namespace Sort
{
    class insertionSort
    {
        public string InsertionSort(int[] array)
        {
            long comparacao = 0;
            long troca = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];

                comparacao++;

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--; ;
                }
                array[j + 1] = temp;

                troca++;
            }
            return "Quantidade de comparações: " + comparacao + "\nQuantidade de trocas: " + troca;
        }
    }
}
