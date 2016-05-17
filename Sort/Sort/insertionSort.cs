namespace Sort
{
    class insertionSort
    {
        public static long comparacao = 0;
        public static long troca = 0;

        public string InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];

                comparacao++;

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];

                    troca++;

                    j--;
                }
                array[j + 1] = temp;
            }
            return "Quantidade de comparações: " + comparacao + "\nQuantidade de trocas: " + troca;
        }
    }
}
