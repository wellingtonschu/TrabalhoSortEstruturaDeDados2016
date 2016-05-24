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

            //Inicia classes com funções de ordenação - 10000 - Crescentes
            bubbleSort b1Cr = new bubbleSort();
            selectionSort s1Cr = new selectionSort();
            insertionSort i1Cr = new insertionSort();
            mergeSort m1Cr = new mergeSort();
            quickSort q1Cr = new quickSort();

            //Inicia classes com funções de ordenação - 100000 - Crescentes
            bubbleSort b2Cr = new bubbleSort();
            selectionSort s2Cr = new selectionSort();
            insertionSort i2Cr = new insertionSort();
            mergeSort m2Cr = new mergeSort();
            quickSort q2Cr = new quickSort();

            //Inicia classes com funções de ordenação - 10000 - Decrescentes
            bubbleSort b1De = new bubbleSort();
            selectionSort s1De = new selectionSort();
            insertionSort i1De = new insertionSort();
            mergeSort m1De = new mergeSort();
            quickSort q1De = new quickSort();

            //Inicia classes com funções de ordenação - 100000 - Decrescentes
            bubbleSort b2De = new bubbleSort();
            selectionSort s2De = new selectionSort();
            insertionSort i2De = new insertionSort();
            mergeSort m2De = new mergeSort();
            quickSort q2De = new quickSort();

            //Inicia classes com funções de ordenação - 10000 - Decrescentes
            bubbleSort b1Al = new bubbleSort();
            selectionSort s1Al = new selectionSort();
            insertionSort i1Al = new insertionSort();
            mergeSort m1Al = new mergeSort();
            quickSort q1Al = new quickSort();

            //Inicia classes com funções de ordenação - 100000 - Decrescentes
            bubbleSort b2Al = new bubbleSort();
            selectionSort s2Al = new selectionSort();
            insertionSort i2Al = new insertionSort();
            mergeSort m2Al = new mergeSort();
            quickSort q2Al = new quickSort();

            //Declaração do tamanho dos vetores
            int tamanhoArray1 = 10000;
            int tamanhoArray2 = 100000;
            
            //Declaração e preenchimento do vetor de 10000 elementos com números crescentes
            int auxVetorBuCr1 = 0;
            int[] array1BubbleCrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1BubbleCrescentes.Length; y++)
            {
                array1BubbleCrescentes[y] = auxVetorBuCr1++;
            }

            int auxVetorSeCr1 = 0;
            int[] array1SelectionCrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1SelectionCrescentes.Length; y++)
            {
                array1SelectionCrescentes[y] = auxVetorSeCr1++;
            }

            int auxVetorInCr1 = 0;
            int[] array1InsertionCrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1InsertionCrescentes.Length; y++)
            {
                array1InsertionCrescentes[y] = auxVetorInCr1++;
            }

            int auxVetorMeCr1 = 0;
            int[] array1MergeCrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1MergeCrescentes.Length; y++)
            {
                array1MergeCrescentes[y] = auxVetorMeCr1++;
            }

            int auxVetorQuCr1 = 0;
            int[] array1QuickCrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1QuickCrescentes.Length; y++)
            {
                array1QuickCrescentes[y] = auxVetorQuCr1++;
            }

            //Declaração e preenchimento do vetor de 100000 elementos com números crescentes
            int auxVetorBuCr2 = 0;
            int[] array2BubbleCrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2BubbleCrescentes.Length; y++)
            {
                array2BubbleCrescentes[y] = auxVetorBuCr2++;
            }

            int auxVetorSeCr2 = 0;
            int[] array2SelectionCrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2SelectionCrescentes.Length; y++)
            {
                array2SelectionCrescentes[y] = auxVetorSeCr2++;
            }

            int auxVetorInCr2 = 0;
            int[] array2InsertionCrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2InsertionCrescentes.Length; y++)
            {
                array2InsertionCrescentes[y] = auxVetorInCr2++;
            }

            int auxVetorMeCr2 = 0;
            int[] array2MergeCrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2MergeCrescentes.Length; y++)
            {
                array2MergeCrescentes[y] = auxVetorMeCr2++;
            }

            int auxVetorQuCr2 = 0;
            int[] array2QuickCrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2QuickCrescentes.Length; y++)
            {
                array2QuickCrescentes[y] = auxVetorQuCr2++;
            }

            //Declaração e preenchimento do vetor de 10000 elementos com números decrescentes
            int auxVetorBuDe1 = tamanhoArray1;
            int[] array1BubbleDecrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1BubbleDecrescentes.Length; y++)
            {
                array1BubbleDecrescentes[y] = auxVetorBuDe1--;
            }

            int auxVetorSeDe1 = tamanhoArray1;
            int[] array1SelectionDecrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1SelectionDecrescentes.Length; y++)
            {
                array1SelectionDecrescentes[y] = auxVetorSeDe1--;
            }

            int auxVetorInDe1 = tamanhoArray1;
            int[] array1InsertionDecrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1InsertionDecrescentes.Length; y++)
            {
                array1InsertionDecrescentes[y] = auxVetorInDe1--;
            }

            int auxVetorMeDe1 = tamanhoArray1;
            int[] array1MergeDecrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1MergeDecrescentes.Length; y++)
            {
                array1MergeDecrescentes[y] = auxVetorMeDe1--;
            }

            int auxQuVetorDe1 = tamanhoArray1;
            int[] array1QuickDecrescentes = new int[tamanhoArray1];
            for (int y = 0; y < array1QuickDecrescentes.Length; y++)
            {
                array1QuickDecrescentes[y] = auxQuVetorDe1--;
            }

            //Declaração e preenchimento do vetor de 100000 elementos com números decrescentes
            int auxVetorBuDe2 = tamanhoArray2;
            int[] array2BubbleDecrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2BubbleDecrescentes.Length; y++)
            {
                array2BubbleDecrescentes[y] = auxVetorBuDe2--;
            }

            int auxVetorSeDe2 = tamanhoArray2;
            int[] array2SelectionDecrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2SelectionDecrescentes.Length; y++)
            {
                array2SelectionDecrescentes[y] = auxVetorSeDe2--;
            }

            int auxVetorInDe2 = tamanhoArray2;
            int[] array2InsertionDecrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2InsertionDecrescentes.Length; y++)
            {
                array2InsertionDecrescentes[y] = auxVetorInDe2--;
            }

            int auxVetorMeDe2 = tamanhoArray2;
            int[] array2MergeDecrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2MergeDecrescentes.Length; y++)
            {
                array2MergeDecrescentes[y] = auxVetorMeDe2--;
            }

            int auxQuVetorDe2 = tamanhoArray2;
            int[] array2QuickDecrescentes = new int[tamanhoArray2];
            for (int y = 0; y < array2QuickDecrescentes.Length; y++)
            {
                array2QuickDecrescentes[y] = auxQuVetorDe2--;
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

            Console.WriteLine("Pressione qualquer tecla para iniciar");
            Console.ReadKey();

            //Execução das funções de ordenação com vetores de 10000 elementos aleatórios 
            Console.WriteLine("Bubble Sort - " + tamanhoArray1 + " - Crescente");
            st.Start();
            b1Cr.BubbleSort(array1BubbleCrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b1Cr.BubbleSort(array1BubbleCrescentes));
            Console.WriteLine("Bubble Sort - " + tamanhoArray1 + " - Crescente Finalizado");

            Console.WriteLine("\nSelection Sort - " + tamanhoArray1 + " - Crescente");  
            st.Restart();
            s1Cr.SelectionSort(array1SelectionCrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s1Cr.SelectionSort(array1SelectionCrescentes));
            Console.WriteLine("Selection Sort - " + tamanhoArray1 + " - Crescente Finalizado");

            Console.WriteLine("\nInsertion Sort - " + tamanhoArray1 + " - Crescente");
            st.Restart();
            i1Cr.InsertionSort(array1InsertionCrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i1Cr.InsertionSort(array1InsertionCrescentes));
            Console.WriteLine("Insertion Sort - " + tamanhoArray1 + " - Crescente Finalizado");

            Console.WriteLine("\nMerge Sort - " + tamanhoArray1 + " - Crescente");
            st.Restart();
            m1Cr.MergeSort(array1MergeCrescentes, 0, array1MergeCrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m1Cr.MergeSort(array1MergeCrescentes, 0, array1MergeCrescentes.Length - 1));
            Console.WriteLine("Merge Sort - " + tamanhoArray1 + " - Crescente Finalizado");

            Console.WriteLine("\nQuick Sort - " + tamanhoArray1 + " - Crescente");
            st.Restart();
            q1Cr.QuickSort(array1QuickCrescentes, 0, array1QuickCrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q1Cr.QuickSort(array1QuickCrescentes, 0, array1QuickCrescentes.Length - 1));
            Console.WriteLine("Quick Sort - " + tamanhoArray1 + " - Crescente Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos crescentes 
            Console.WriteLine("\nBubble Sort - " + tamanhoArray2 + " - Crescente");
            st.Start();
            b2Cr.BubbleSort(array2BubbleCrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b2Cr.BubbleSort(array2BubbleCrescentes));
            Console.WriteLine("Bubble Sort - " + tamanhoArray2 + " - Crescente Finalizado");

            Console.WriteLine("\nSelection Sort - " + tamanhoArray2 + " - Crescente");
            st.Restart();
            s2Cr.SelectionSort(array2SelectionCrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s2Cr.SelectionSort(array2SelectionCrescentes));
            Console.WriteLine("Selection Sort - " + tamanhoArray2 + " - Crescente Finalizado");

            Console.WriteLine("\nInsertion Sort - " + tamanhoArray2 + " - Crescente");
            st.Restart();
            i2Cr.InsertionSort(array2InsertionCrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i2Cr.InsertionSort(array2InsertionCrescentes));
            Console.WriteLine("Insertion Sort - " + tamanhoArray2 + " - Crescente Finalizado");

            Console.WriteLine("\nMerge Sort - " + tamanhoArray2 + " - Crescente");
            st.Restart();
            m2Cr.MergeSort(array2MergeCrescentes, 0, array2MergeCrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m2Cr.MergeSort(array2MergeCrescentes, 0, array2MergeCrescentes.Length - 1));
            Console.WriteLine("Merge Sort - " + tamanhoArray2 + " - Crescente Finalizado");
            
            Console.WriteLine("\nQuick Sort - " + tamanhoArray2 + " - Crescente");
            st.Restart();
            q2Cr.QuickSort(array2QuickCrescentes, 0, array2QuickCrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q2Cr.QuickSort(array2QuickCrescentes, 0, array2QuickCrescentes.Length - 1));
            Console.WriteLine("Quick Sort - " + tamanhoArray2 + " - Crescente Finalizado");
            
            //Execução das funções de ordenação com vetores de 10000 elementos decrescentes 
            Console.WriteLine("\nBubble Sort - " + tamanhoArray1 + " - Decrescente");
            st.Start();
            b1De.BubbleSort(array1BubbleDecrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b1De.BubbleSort(array1BubbleDecrescentes));
            Console.WriteLine("Bubble Sort - " + tamanhoArray1 + " - Decrescente Finalizado");

            Console.WriteLine("\nSelection Sort - " + tamanhoArray1 + " - Decrescente");
            st.Restart();
            s1De.SelectionSort(array1InsertionDecrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s1De.SelectionSort(array1InsertionDecrescentes));
            Console.WriteLine("Selection Sort - " + tamanhoArray1 + " - Decrescente Finalizado");

            Console.WriteLine("\nInsertion Sort - " + tamanhoArray1 + " - Decrescente");
            st.Restart();
            i1De.InsertionSort(array1SelectionDecrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i1De.InsertionSort(array1SelectionDecrescentes));
            Console.WriteLine("Insertion Sort - " + tamanhoArray1 + " - Decrescente Finalizado");

            Console.WriteLine("\nMerge Sort - " + tamanhoArray1 + " - Decrescente");
            st.Restart();
            m1De.MergeSort(array1MergeDecrescentes, 0, array1MergeDecrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m1De.MergeSort(array1MergeDecrescentes, 0, array1MergeDecrescentes.Length - 1));
            Console.WriteLine("Merge Sort - " + tamanhoArray1 + " - Decrescente Finalizado");

            Console.WriteLine("\nQuick Sort - " + tamanhoArray1 + " - Decrescente");
            st.Restart();
            q1De.QuickSort(array1QuickDecrescentes, 0, array1QuickDecrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q1De.QuickSort(array1QuickDecrescentes, 0, array1QuickDecrescentes.Length - 1));
            Console.WriteLine("Quick Sort - " + tamanhoArray1 + " - Decrescente Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos decrescentes
            Console.WriteLine("\nBubble Sort - " + tamanhoArray2 + " - Decrescente");
            st.Start();
            b2De.BubbleSort(array2BubbleDecrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b2De.BubbleSort(array2BubbleDecrescentes));
            Console.WriteLine("Bubble Sort - " + tamanhoArray2 + " - Decrescente Finalizado");

            Console.WriteLine("\nSelection Sort - " + tamanhoArray2 + " - Decrescente");
            st.Restart();
            s2De.SelectionSort(array2SelectionDecrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s2De.SelectionSort(array2SelectionDecrescentes));
            Console.WriteLine("Selection Sort - " + tamanhoArray2 + " - Decrescente Finalizado");

            Console.WriteLine("\nInsertion Sort - " + tamanhoArray2 + " - Decrescente");
            st.Restart();
            i2De.InsertionSort(array2InsertionDecrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i2De.InsertionSort(array2InsertionDecrescentes));
            Console.WriteLine("Insertion Sort - " + tamanhoArray2 + " - Decrescente Finalizado");

            Console.WriteLine("\nMerge Sort - " + tamanhoArray2 + " - Decrescente");
            st.Restart();
            m2De.MergeSort(array2MergeDecrescentes, 0, array2MergeDecrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m2De.MergeSort(array2MergeDecrescentes, 0, array2MergeDecrescentes.Length - 1));
            Console.WriteLine("Merge Sort - " + tamanhoArray2 + " - Decrescente Finalizado");

            Console.WriteLine("\nQuick Sort - " + tamanhoArray2 + " - Decrescente");
            st.Restart();
            q2De.QuickSort(array2QuickDecrescentes, 0, array2QuickDecrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q2De.QuickSort(array2QuickDecrescentes, 0, array2QuickDecrescentes.Length - 1));
            Console.WriteLine("Quick Sort - " + tamanhoArray2 + " - Decrescente Finalizado");

            //Execução das funções de ordenação com vetores de 10000 elementos aleatórios
            Console.WriteLine("\nBubble Sort - " + tamanhoArray1 + " - Aleatórios");
            st.Start();
            b1Al.BubbleSort(array1BubbleRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b1Al.BubbleSort(array1BubbleRandom));
            Console.WriteLine("Bubble Sort - " + tamanhoArray1 + " - Aleatórios Finalizado");

            Console.WriteLine("\nSelection Sort - " + tamanhoArray1 + " - Aleatórios");
            st.Restart();
            s1Al.SelectionSort(array1SelectionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s1Al.SelectionSort(array1SelectionRandom));
            Console.WriteLine("Selection Sort - " + tamanhoArray1 + " - Aleatórios Finalizado");

            Console.WriteLine("\nInsertion Sort - " + tamanhoArray1 + " - Aleatórios");
            st.Restart();
            i1Al.InsertionSort(array1InsertionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i1Al.InsertionSort(array1InsertionRandom));
            Console.WriteLine("Insertion Sort - " + tamanhoArray1 + " - Aleatórios Finalizado");

            Console.WriteLine("\nMerge Sort - " + tamanhoArray1 + " - Aleatórios");
            st.Restart();
            m1Al.MergeSort(array1MergeRandom, 0, array1MergeRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m1Al.MergeSort(array1MergeRandom, 0, array1MergeRandom.Length - 1));
            Console.WriteLine("Merge Sort - " + tamanhoArray1 + " - Aleatórios Finalizado");

            Console.WriteLine("\nQuick Sort - " + tamanhoArray1 + " - Aleatórios");
            st.Restart();
            q1Al.QuickSort(array1QuickRandom, 0, array1QuickRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q1Al.QuickSort(array1QuickRandom, 0, array1QuickRandom.Length - 1));
            Console.WriteLine("Quick Sort - " + tamanhoArray1 + " - Aleatórios Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos aleatórios 
            Console.WriteLine("\nBubble Sort - " + tamanhoArray2 + " - Aleatórios");
            st.Restart();
            b2Al.BubbleSort(array2BubbleRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b2Al.BubbleSort(array2BubbleRandom));
            Console.WriteLine("Bubble Sort - " + tamanhoArray2 + " - Aleatórios Finalizado");

            Console.WriteLine("\nSelection Sort - " + tamanhoArray2 + " - Aleatórios");
            st.Restart();
            s2Al.SelectionSort(array2SelectionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s2Al.SelectionSort(array2SelectionRandom));
            Console.WriteLine("Selection Sort - " + tamanhoArray2 + " - Aleatórios Finalizado");

            Console.WriteLine("\nInsertion Sort - " + tamanhoArray2 + " - Aleatórios");
            st.Restart();
            i2Al.InsertionSort(array2InsertionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i2Al.InsertionSort(array2InsertionRandom));
            Console.WriteLine("Insertion Sort - " + tamanhoArray2 + " - Aleatórios Finalizado");

            Console.WriteLine("\nMerge Sort - " + tamanhoArray2 + " - Aleatórios");
            st.Restart();
            m2Al.MergeSort(array2MergeRandom, 0, array2MergeRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m2Al.MergeSort(array2MergeRandom, 0, array2MergeRandom.Length - 1));
            Console.WriteLine("Merge Sort - " + tamanhoArray2 + " - Aleatórios Finalizado");

            Console.WriteLine("\nQuick Sort - " + tamanhoArray2 + " - Aleatórios");
            st.Restart();
            q2Al.QuickSort(array2QuickRandom, 0, array2QuickRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q2Al.QuickSort(array2QuickRandom, 0, array2QuickRandom.Length - 1));
            Console.WriteLine("Quick Sort - " + tamanhoArray2 + " - Aleatórios Finalizado");
            
            Console.WriteLine("\nPressione qualquer tecla para finalizar");

            Console.ReadKey();
        }
    }
}
