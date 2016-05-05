namespace Sort
{
    class quickSort
    {
        public void QuickSort(int[] array, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = particao(array, inicio, fim);
                QuickSort(array, inicio, meio - 1);
                QuickSort(array, meio + 1, fim);
            }
        }

        private static int particao(int[] array, int inicio, int fim)
        {
            int pivot = array[fim];
            int menor = inicio - 1;

            for (int i = inicio; i < fim; i++)
            {
                if (array[i] <= pivot)
                {
                    menor++;
                    troca(array, i, menor);
                }
            }

            troca(array, fim, menor + 1);

            return menor + 1;
        }
        
        private static void troca(int[] array, int i, int menor)
        {
            int temp;

            temp = array[i];
            array[i] = array[menor];
            array[menor] = temp;
        }
    }
}
