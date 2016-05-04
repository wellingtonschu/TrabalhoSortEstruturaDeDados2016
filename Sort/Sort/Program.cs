using System;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicia biblioteca do cronômetro
            Stopwatch st = new Stopwatch();
            //Inicia biblioteca de numeros randomicos
            Random rnd = new Random();

            //Inicia classes com funções de ordenação
            bubbleSort b = new bubbleSort();
            selectionSort s = new selectionSort();
            insertionSort i = new insertionSort();
            mergeSort m = new mergeSort();
            quickSort q = new quickSort();

            //Declaração do tamanho dos vetores
            int tamanhoArray1 = 10000;
            int tamanhoArray2 = 100000;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 10000 elementos aleatórios
             */
            long tempo1BubbleRandom;
            long tempo1SelectionRandom;
            long tempo1InsertionRandom;
            long tempo1MergeRandom;
            long tempo1QuickRandom;

            //Preenchimento do vetor de 10000 elementos com números aleatórios
            int[] array1BubbleRandom = new int[tamanhoArray1]; 
            for (int y = 0; y < array1BubbleRandom.Length; y++)
            {
                array1BubbleRandom[y] = rnd.Next();
            }

            int[] array1SelectionRandom = new int[tamanhoArray1];
            for (int y = 0; y < array1SelectionRandom.Length; y++)
            {
                array1SelectionRandom[y] = rnd.Next();
            }

            int[] array1InsertionRandom = new int[tamanhoArray1];
            for (int y = 0; y < array1InsertionRandom.Length; y++)
            {
                array1InsertionRandom[y] = rnd.Next();
            }

            int[] array1MergeRandom = new int[tamanhoArray1];
            for (int y = 0; y < array1MergeRandom.Length; y++)
            {
                array1MergeRandom[y] = rnd.Next();
            }

            int[] array1QuickRandom = new int[tamanhoArray1];
            for (int y = 0; y < array1QuickRandom.Length; y++)
            {
                array1QuickRandom[y] = rnd.Next();
            }

            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 10000 - Aleatórios");
            Console.ReadKey();
            
            st.Start();
            b.BubbleSort(array1BubbleRandom);
            st.Stop();
            tempo1BubbleRandom = st.ElapsedTicks;

            Console.WriteLine("Bubble Sort Finalizado");
            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 10000 - Aleatórios");
            Console.ReadKey();
            
            st.Restart();
            s.SelectionSort(array1SelectionRandom);
            st.Stop();
            tempo1SelectionRandom = st.ElapsedTicks;

            Console.WriteLine("Selection Sort Finalizado");
            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 10000 - Aleatórios");
            Console.ReadKey();
            
            st.Restart();
            i.InsertionSort(array1InsertionRandom);
            st.Stop();
            tempo1InsertionRandom = st.ElapsedTicks;

            Console.WriteLine("Insertion Sort Finalizado");
            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 10000 - Aleatórios");
            Console.ReadKey();
            
            st.Restart();
            m.MergeSort(array1MergeRandom, 0, array1MergeRandom.Length - 1);
            st.Stop();
            tempo1MergeRandom = st.ElapsedTicks;

            Console.WriteLine("Merge Sort Finalizado");
            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 10000 - Aleatórios");
            Console.ReadKey();
            
            st.Restart();
            q.QuickSort(array1QuickRandom, 0, array1QuickRandom.Length - 1);
            st.Stop();
            tempo1QuickRandom = st.ElapsedTicks;

            Console.WriteLine("Quick Sort Finalizado");
            Console.WriteLine("Pressione qualquer tecla para resultados");

            Console.ReadKey();

            Console.WriteLine("Tempo de execução aleatórios: ");

            Console.WriteLine("\nTempo de execução Bubble Sort: " + tempo1BubbleRandom);
            Console.WriteLine("Tempo de execução Selection Sort: " + tempo1SelectionRandom);
            Console.WriteLine("Tempo de execução Insertion Sort: " + tempo1InsertionRandom);
            Console.WriteLine("Tempo de execução Merge Sort: " + tempo1MergeRandom);
            Console.WriteLine("Tempo de execução Quick Sort: " + tempo1QuickRandom);

            Console.ReadKey();
        }
    }
}
