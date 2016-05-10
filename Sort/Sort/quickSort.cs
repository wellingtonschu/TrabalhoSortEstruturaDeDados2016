namespace Sort
{
    class quickSort
    {
        public void QuickSort(int[] array, int inicio, int fim)
        {
            int q;

            if (inicio < fim)
            {
                q = particao(array, inicio, fim);
                QuickSort(array, inicio, q);
                QuickSort(array, q + 1, fim);
            }
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
                } while (array[j] > pivo);
                do
                {
                    i = i + 1;
                } while (array[i] < pivo);

                if (i < j)
                {
                    aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                }
            }
            return j;
        }
    }
}