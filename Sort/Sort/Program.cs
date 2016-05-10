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
            radixSort r = new radixSort();

            //Declaração do tamanho dos vetores
            int tamanhoArray1 = 10000;
            int tamanhoArray2 = 100000;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 10000 elementos em ordem crescente
             */
            long tempo1BubbleCrescente;
            long tempo1SelectionCrescente;
            long tempo1InsertionCrescente;
            long tempo1MergeCrescente;
            long tempo1QuickCrescente;
            long tempo1RadixCrescente;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 100000 elementos em ordem crescente
             */
            long tempo2BubbleCrescente;
            long tempo2SelectionCrescente;
            long tempo2InsertionCrescente;
            long tempo2MergeCrescente;
            long tempo2QuickCrescente;
            long tempo2RadixCrescente;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 10000 elementos em ordem decrescente
             */
            long tempo1BubbleDecrescente;
            long tempo1SelectionDecrescente;
            long tempo1InsertionDecrescente;
            long tempo1MergeDecrescente;
            long tempo1QuickDecrescente;
            long tempo1RadixDecrescente;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 100000 elementos em ordem decrescente
             */
            long tempo2BubbleDecrescente;
            long tempo2SelectionDecrescente;
            long tempo2InsertionDecrescente;
            long tempo2MergeDecrescente;
            long tempo2QuickDecrescente;
            long tempo2RadixDecrescente;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 10000 elementos aleatórios
             */
            long tempo1BubbleRandom;
            long tempo1SelectionRandom;
            long tempo1InsertionRandom;
            long tempo1MergeRandom;
            long tempo1QuickRandom;
            long tempo1RadixRandom;

            /*Declaração de variaveis para armazenamenoto da contagem de tempo de execução das
             * funções num vetor de 100000 elementos aleatórios
             */
            long tempo2BubbleRandom;
            long tempo2SelectionRandom;
            long tempo2InsertionRandom;
            long tempo2MergeRandom;
            long tempo2QuickRandom;
            long tempo2RadixRandom;

            //Declaração e preenchimento do vetor de 10000 elementos com números crescentes
            int auxVetorCr1 = 0;
            int[] array1Crescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1Crescentes.Length; y++)
            {
                array1Crescentes[y] = auxVetorCr1++;
            }

            //Declaração e preenchimento do vetor de 100000 elementos com números crescentes
            int auxVetorCr2 = 0;
            int[] array2Crescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2Crescentes.Length; y++)
            {
                array2Crescentes[y] = auxVetorCr2++;
            }

            //Declaração e preenchimento do vetor de 10000 elementos com números decrescentes
            int auxVetorDe1 = 10000;
            int[] array1Decrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1Decrescentes.Length; y++)
            {
                array1Decrescentes[y] = auxVetorDe1--;
            }

            //Declaração e preenchimento do vetor de 100000 elementos com números decrescentes
            int auxVetorDe2 = 100000;
            int[] array2Decrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2Decrescentes.Length; y++)
            {
                array2Decrescentes[y] = auxVetorDe2--;
            }

            //Declaração e preenchimento do vetor de 10000 elementos com números aleatórios
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

            int[] array1RadixRandom = new int[tamanhoArray1];
            for (int y = 0; y < array1RadixRandom.Length; y++)
            {
                array1RadixRandom[y] = rnd.Next();
            }

            //Declaração e preenchimento do vetor de 100000 elementos com números aleatórios
            int[] array2BubbleRandom = new int[tamanhoArray2];
            for (int y = 0; y < array2BubbleRandom.Length; y++)
            {
                array2BubbleRandom[y] = rnd.Next();
            }

            int[] array2SelectionRandom = new int[tamanhoArray2];
            for (int y = 0; y < array1SelectionRandom.Length; y++)
            {
                array2SelectionRandom[y] = rnd.Next();
            }

            int[] array2InsertionRandom = new int[tamanhoArray2];
            for (int y = 0; y < array2InsertionRandom.Length; y++)
            {
                array2InsertionRandom[y] = rnd.Next();
            }

            int[] array2MergeRandom = new int[tamanhoArray2];
            for (int y = 0; y < array2MergeRandom.Length; y++)
            {
                array2MergeRandom[y] = rnd.Next();
            }

            int[] array2QuickRandom = new int[tamanhoArray2];
            for (int y = 0; y < array2QuickRandom.Length; y++)
            {
                array2QuickRandom[y] = rnd.Next();
            }

            int[] array2RadixRandom = new int[tamanhoArray2];
            for (int y = 0; y < array2RadixRandom.Length; y++)
            {
                array2RadixRandom[y] = rnd.Next();
            }

            //Execução das funções de ordenação com vetores de 10000 elementos aleatórios 
            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array1Crescentes);
            st.Stop();
            tempo1BubbleCrescente = st.ElapsedTicks;
            Console.WriteLine("Bubble Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array1Crescentes);
            st.Stop();
            tempo1SelectionCrescente = st.ElapsedTicks;
            Console.WriteLine("Selection Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array1Crescentes);
            st.Stop();
            tempo1InsertionCrescente = st.ElapsedTicks;
            Console.WriteLine("Insertion Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array1Crescentes, 0, array1Crescentes.Length - 1);
            st.Stop();
            tempo1MergeCrescente = st.ElapsedTicks;
            Console.WriteLine("Merge Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array1Crescentes, 0, array1Crescentes.Length - 1);
            st.Stop();
            tempo1QuickCrescente = st.ElapsedTicks;
            Console.WriteLine("Quick Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Radix Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            r.RadixSort(array1Crescentes);
            st.Stop();
            tempo1RadixCrescente = st.ElapsedTicks;
            Console.WriteLine("Radix sort - 10000 - Crescente Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos crescentes 
            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array2Crescentes);
            st.Stop();
            tempo2BubbleCrescente = st.ElapsedTicks;
            Console.WriteLine("Bubble Sort - 100000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array2Crescentes);
            st.Stop();
            tempo2SelectionCrescente = st.ElapsedTicks;
            Console.WriteLine("Selection Sort - 100000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array2Crescentes);
            st.Stop();
            tempo2InsertionCrescente = st.ElapsedTicks;
            Console.WriteLine("Insertion Sort - 100000 - Crescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array2Crescentes, 0, array2Crescentes.Length - 1);
            st.Stop();
            tempo2MergeCrescente = st.ElapsedTicks;
            Console.WriteLine("Merge Sort - 100000 - Crescente Finalizado");
            
            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array2Crescentes, 0, array2Crescentes.Length - 1);
            st.Stop();
            tempo2QuickCrescente = st.ElapsedTicks;
            Console.WriteLine("Quick Sort - 100000 - Crescente Finalizado");
            
            Console.WriteLine("Pressione qualquer tecla para iniciar - Radix Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            r.RadixSort(array2Crescentes);
            st.Stop();
            tempo2RadixCrescente = st.ElapsedTicks;
            Console.WriteLine("Radix sort - 100000 - Crescente Finalizado");
            
            //Execução das funções de ordenação com vetores de 10000 elementos decrescentes 
            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array1Decrescentes);
            st.Stop();
            tempo1BubbleDecrescente = st.ElapsedTicks;
            Console.WriteLine("Bubble Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array1Decrescentes);
            st.Stop();
            tempo1SelectionDecrescente = st.ElapsedTicks;
            Console.WriteLine("Selection Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array1Decrescentes);
            st.Stop();
            tempo1InsertionDecrescente = st.ElapsedTicks;
            Console.WriteLine("Insertion Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array1Decrescentes, 0, array1Decrescentes.Length - 1);
            st.Stop();
            tempo1MergeDecrescente = st.ElapsedTicks;
            Console.WriteLine("Merge Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array1Decrescentes, 0, array1Decrescentes.Length - 1);
            st.Stop();
            tempo1QuickDecrescente = st.ElapsedTicks;
            Console.WriteLine("Quick Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Radix Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            r.RadixSort(array1Decrescentes);
            st.Stop();
            tempo1RadixDecrescente = st.ElapsedTicks;
            Console.WriteLine("Radix sort - 10000 - Decrescente Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos decrescentes
            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array2Decrescentes);
            st.Stop();
            tempo2BubbleDecrescente = st.ElapsedTicks;
            Console.WriteLine("Bubble Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array2Decrescentes);
            st.Stop();
            tempo2SelectionDecrescente = st.ElapsedTicks;
            Console.WriteLine("Selection Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array2Decrescentes);
            st.Stop();
            tempo2InsertionDecrescente = st.ElapsedTicks;
            Console.WriteLine("Insertion Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array2Decrescentes, 0, array2Decrescentes.Length - 1);
            st.Stop();
            tempo2MergeDecrescente = st.ElapsedTicks;
            Console.WriteLine("Merge Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array2Decrescentes, 0, array2Decrescentes.Length - 1);
            st.Stop();
            tempo2QuickDecrescente = st.ElapsedTicks;
            Console.WriteLine("Quick Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Radix Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            r.RadixSort(array2Decrescentes);
            st.Stop();
            tempo2RadixDecrescente = st.ElapsedTicks;
            Console.WriteLine("Radix sort - 100000 - Decrescente Finalizado");

            //Execução das funções de ordenação com vetores de 10000 elementos aleatórios
            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array1BubbleRandom);
            st.Stop();
            tempo1BubbleRandom = st.ElapsedTicks;
            Console.WriteLine("Bubble Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array1SelectionRandom);
            st.Stop();
            tempo1SelectionRandom = st.ElapsedTicks;
            Console.WriteLine("Selection Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array1InsertionRandom);
            st.Stop();
            tempo1InsertionRandom = st.ElapsedTicks;
            Console.WriteLine("Insertion Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array1MergeRandom, 0, array1MergeRandom.Length - 1);
            st.Stop();
            tempo1MergeRandom = st.ElapsedTicks;
            Console.WriteLine("Merge Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array1QuickRandom, 0, array1QuickRandom.Length - 1);
            st.Stop();
            tempo1QuickRandom = st.ElapsedTicks;
            Console.WriteLine("Quick Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Radix Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            r.RadixSort(array1RadixRandom);
            st.Stop();
            tempo1RadixRandom = st.ElapsedTicks;
            Console.WriteLine("Radix Sort - 10000 - Aleatórios Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos aleatórios 
            Console.WriteLine("Pressione qualquer tecla para iniciar - Bubble Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            b.BubbleSort(array2BubbleRandom);
            st.Stop();
            tempo2BubbleRandom = st.ElapsedTicks;
            Console.WriteLine("Bubble Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Selection Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array2SelectionRandom);
            st.Stop();
            tempo2SelectionRandom = st.ElapsedTicks;
            Console.WriteLine("Selection Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Insertion Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array2InsertionRandom);
            st.Stop();
            tempo2InsertionRandom = st.ElapsedTicks;
            Console.WriteLine("Insertion Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Merge Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array2MergeRandom, 0, array2MergeRandom.Length - 1);
            st.Stop();
            tempo2MergeRandom = st.ElapsedTicks;
            Console.WriteLine("Merge Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Quick Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array2QuickRandom, 0, array2QuickRandom.Length - 1);
            st.Stop();
            tempo2QuickRandom = st.ElapsedTicks;
            Console.WriteLine("Quick Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("Pressione qualquer tecla para iniciar - Radix Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            r.RadixSort(array2RadixRandom);
            st.Stop();
            tempo2RadixRandom = st.ElapsedTicks;
            Console.WriteLine("Radix Sort - 100000 - Aleatórios Finalizado");
            
            Console.WriteLine("Pressione qualquer tecla para resultados");

            Console.ReadKey();

            Console.WriteLine("\nTempo de execução - 10000 - Crescente: ");
            
            Console.WriteLine("\nTempo de execução Bubble Sort - 10000 - Crescente: " + tempo1BubbleCrescente);
            Console.WriteLine("Tempo de execução Selection Sort - 10000 - Crescente: " + tempo1SelectionCrescente);
            Console.WriteLine("Tempo de execução Insertion Sort - 10000 - Crescente: " + tempo1InsertionCrescente);
            Console.WriteLine("Tempo de execução Merge Sort - 10000 - Crescente: " + tempo1MergeCrescente);
            Console.WriteLine("Tempo de execução Quick Sort - 10000 - Crescente: " + tempo1QuickCrescente);
            Console.WriteLine("Tempo de execução Radix Sort - 10000 - Crescente: " + tempo1RadixCrescente);

            Console.WriteLine("\nTempo de execução - 100000 - Crescente: ");

            Console.WriteLine("\nTempo de execução Bubble Sort - 100000 - Crescente: " + tempo2BubbleCrescente);
            Console.WriteLine("Tempo de execução Selection Sort - 100000 - Crescente: " + tempo2SelectionCrescente);
            Console.WriteLine("Tempo de execução Insertion Sort - 100000 - Crescente: " + tempo2InsertionCrescente);
            Console.WriteLine("Tempo de execução Merge Sort - 100000 - Crescente: " + tempo2MergeCrescente);
            Console.WriteLine("Tempo de execução Quick Sort - 100000 - Crescente: " + tempo2QuickCrescente);
            Console.WriteLine("Tempo de execução Radix Sort - 100000 - Crescente: " + tempo2RadixCrescente);
            
            Console.WriteLine("\nTempo de execução - 10000 - Decrescente: ");

            Console.WriteLine("\nTempo de execução Bubble Sort - 10000 - Decrescente: " + tempo1BubbleDecrescente);
            Console.WriteLine("Tempo de execução Selection Sort - 10000 - Decrescente: " + tempo1SelectionDecrescente);
            Console.WriteLine("Tempo de execução Insertion Sort - 10000 - Decrescente: " + tempo1InsertionDecrescente);
            Console.WriteLine("Tempo de execução Merge Sort - 10000 - Decrescente: " + tempo1MergeDecrescente);
            Console.WriteLine("Tempo de execução Quick Sort - 10000 - Decrescente: " + tempo1QuickDecrescente);
            Console.WriteLine("Tempo de execução Radix Sort - 10000 - Decrescente: " + tempo1RadixDecrescente);

            Console.WriteLine("\nTempo de execução - 100000 - Decrescente: ");

            Console.WriteLine("\nTempo de execução Bubble Sort - 100000 - Decrescente: " + tempo2BubbleDecrescente);
            Console.WriteLine("Tempo de execução Selection Sort - 100000 - Decrescente: " + tempo2SelectionDecrescente);
            Console.WriteLine("Tempo de execução Insertion Sort - 100000 - Decrescente: " + tempo2InsertionDecrescente);
            Console.WriteLine("Tempo de execução Merge Sort - 100000 - Decrescente: " + tempo2MergeDecrescente);
            Console.WriteLine("Tempo de execução Quick Sort - 100000 - Decrescente: " + tempo2QuickDecrescente);
            Console.WriteLine("Tempo de execução Radix Sort - 100000 - Decrescente: " + tempo2RadixDecrescente);

            Console.WriteLine("\nTempo de execução - 10000 - Aleatórios: ");

            Console.WriteLine("\nTempo de execução Bubble Sort - 10000 - Aleatórios: " + tempo1BubbleRandom);
            Console.WriteLine("Tempo de execução Selection Sort - 10000 - Aleatórios: " + tempo1SelectionRandom);
            Console.WriteLine("Tempo de execução Insertion Sort - 10000 - Aleatórios: " + tempo1InsertionRandom);
            Console.WriteLine("Tempo de execução Merge Sort - 10000 - Aleatórios: " + tempo1MergeRandom);
            Console.WriteLine("Tempo de execução Quick Sort - 10000 - Aleatórios: " + tempo1QuickRandom);
            Console.WriteLine("Tempo de execução Radix Sort - 10000 - Aleatórios: " + tempo1RadixRandom);

            Console.WriteLine("\nTempo de execução - 100000 - Aleatórios: ");

            Console.WriteLine("\nTempo de execução Bubble Sort - 100000 - Aleatórios: " + tempo2BubbleRandom);
            Console.WriteLine("Tempo de execução Selection Sort - 100000 - Aleatórios: " + tempo2SelectionRandom);
            Console.WriteLine("Tempo de execução Insertion Sort - 100000 - Aleatórios: " + tempo2InsertionRandom);
            Console.WriteLine("Tempo de execução Merge Sort - 100000 - Aleatórios: " + tempo2MergeRandom);
            Console.WriteLine("Tempo de execução Quick Sort - 100000 - Aleatórios: " + tempo2QuickRandom);
            Console.WriteLine("Tempo de execução Radix Sort - 100000 - Aleatórios: " + tempo2RadixRandom);

            Console.ReadKey();
        }
    }
}
