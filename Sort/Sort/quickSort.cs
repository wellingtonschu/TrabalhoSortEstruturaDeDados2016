namespace Sort
{
    class quickSort
    {
        public static int troca = 0;
        public static int comparacao = 0;

        public string QuickSort(int[] array, int inicio, int fim)
        {
            int q;

            if (inicio < fim)
            {
                q = particao(array, inicio, fim);
                QuickSort(array, inicio, q);
                QuickSort(array, q + 1, fim);
            }
            return "Quantidade de comparações: " + comparacao + "\nQuantidade de trocas: " + troca;
        }
        public static int particao(int[] array, int inicio, int fim)
        {
            int pivo;
            int i;
            int j;
            int aux;

            pivo = array[(inicio + fim) / 2];
            i = inicio - 1;
            j = fim + 1;

            while (i < j)
            {
                do
                {
                    j = j - 1;

                    comparacao++;

                } while (array[j] > pivo);
                do
                {
                    i = i + 1;

                    comparacao++;

                } while (array[i] < pivo);
                
                if (i < j)
                {
                    troca++;

                    aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                }
            }
            return j;
        }
    }
}