namespace Sort
{
    class bubbleSort
    {
        public string BubbleSort(int[] array)
        {
            long comparacao = 0;
            long troca = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    comparacao++;

                    if (array[j] > array[j + 1])
                    {
                        troca++;

                        int auxiliar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = auxiliar;
                    }
                }
            }
            return "Quantidade de comparações: " + comparacao + "\nQuantidade de trocas: " + troca;
        }
    }
}
