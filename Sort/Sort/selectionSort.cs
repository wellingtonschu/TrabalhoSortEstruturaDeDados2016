namespace Sort
{
    class selectionSort
    {
        public static long comparacao = 0;
        public static long troca = 0;

        public string SelectionSort(int[] array)
        {
            int N = array.Length;

            for (int i = 0; i < N; i++)
            {
                int menor = array[i];
                int posicao = i;

                for (int j = i + 1; j < N; j++)
                {
                    comparacao++;

                    if (array[j] < menor)
                    {
                        menor = array[j];

                        troca++;

                        posicao = j;
                    }
                }

                int temp = array[posicao];

                array[posicao] = array[i];
                array[i] = temp;
            }
            return "Quantidade de comparações: " + comparacao + "\nQuantidade de trocas: " + troca;
        }
    }
}
