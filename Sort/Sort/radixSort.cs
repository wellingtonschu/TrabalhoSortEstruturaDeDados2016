using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class radixSort
    {
        public void RadixSort(int[] array)
        {
            int maximo = Int32.MinValue;

            for(int i = 0; i < array.Length; i++)
            {
                maximo = Math.Max(maximo, array[i]);
            }

            int p = 1;
            int pass = 1;

            while(maximo / p > 0)
            {
                array = countingSort(array, array.Length, p);
                pass++;
                p *= 10;
            }

        } 

        public static int[] countingSort(int[] array, int N, int p)
        {
            int[] saida = new int[N];
            int[] contador = new int[10];

            for(int i = 0; i < N; i++)
            {
                contador[(array[i] / p) % 10]++;
            }

            for(int i = 1; i < 10; i++)
            {
                contador[i] += contador[i - 1];
            }

            for(int i = N-1; i >= 0; i--)
            {
                saida[contador[(array[i] / p) % 10] - 1] = array[i];
                contador[(array[i] / p) % 10]--;
            }

            return saida;
        }

    }
}
