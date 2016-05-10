﻿namespace Sort
{
    class mergeSort
    {
        int troca = 0;
        int comparacao = 0;
        public void MergeSort(int[] array, int inicio, int fim)
        {
            int meio = 0;

            if (inicio < fim)
            {
                meio = (inicio + fim) / 2;

                MergeSort(array, inicio, meio);
                MergeSort(array, meio + 1, fim);

                Merge(array, inicio, meio, fim);
            }
        }

        private void Merge(int[] array, int inicio, int meio, int fim)
        {
            int cont = 0;
            int[] aux = new int[array.Length];
            int i, j;

            for (i = inicio; i <= meio;i++)
            {
                aux[i] = array[i];
            }

            for (j = meio + 1;j <= fim;j++)
            {
                aux[fim + meio + 1 - j] = array[j];
            }

            i = inicio;
            j = fim;

            for (int k = inicio; k <= fim; k++)
            {
                comparacao++;
                cont++;
                if (aux[i] <= aux[j])
                {
                    array[k] = aux[i];
                    troca++;
                    i = i + 1;
                }
                else
                {
                    array[k] = aux[j];
                    troca++;
                    j = j - 1;
                }
            }
        }
    }
}
