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
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b.BubbleSort(array1Crescentes));
            Console.WriteLine("Bubble Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Selection Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array1Crescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s.SelectionSort(array1Crescentes));
            Console.WriteLine("Selection Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Insertion Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array1Crescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i.InsertionSort(array1Crescentes));
            Console.WriteLine("Insertion Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Merge Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array1Crescentes, 0, array1Crescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m.MergeSort(array1Crescentes, 0, array1Crescentes.Length - 1));
            Console.WriteLine("Merge Sort - 10000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Quick Sort - 10000 - Crescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array1Crescentes, 0, array1Crescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q.QuickSort(array1Crescentes, 0, array1Crescentes.Length - 1));
            Console.WriteLine("Quick Sort - 10000 - Crescente Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos crescentes 
            Console.WriteLine("\nPressione qualquer tecla para iniciar - Bubble Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array2Crescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b.BubbleSort(array2Crescentes));
            Console.WriteLine("Bubble Sort - 100000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Selection Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array2Crescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s.SelectionSort(array2Crescentes));
            Console.WriteLine("Selection Sort - 100000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Insertion Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array2Crescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i.InsertionSort(array2Crescentes));
            Console.WriteLine("Insertion Sort - 100000 - Crescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Merge Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array2Crescentes, 0, array2Crescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m.MergeSort(array2Crescentes, 0, array2Crescentes.Length - 1));
            Console.WriteLine("Merge Sort - 100000 - Crescente Finalizado");
            
            Console.WriteLine("\nPressione qualquer tecla para iniciar - Quick Sort - 100000 - Crescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array2Crescentes, 0, array2Crescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q.QuickSort(array2Crescentes, 0, array2Crescentes.Length - 1));
            Console.WriteLine("Quick Sort - 100000 - Crescente Finalizado");
            
            //Execução das funções de ordenação com vetores de 10000 elementos decrescentes 
            Console.WriteLine("\nPressione qualquer tecla para iniciar - Bubble Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array1Decrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b.BubbleSort(array1Decrescentes));
            Console.WriteLine("Bubble Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Selection Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array1Decrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s.SelectionSort(array1Decrescentes));
            Console.WriteLine("Selection Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Insertion Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array1Decrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i.InsertionSort(array1Decrescentes));
            Console.WriteLine("Insertion Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Merge Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array1Decrescentes, 0, array1Decrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m.MergeSort(array1Decrescentes, 0, array1Decrescentes.Length - 1));
            Console.WriteLine("Merge Sort - 10000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Quick Sort - 10000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array1Decrescentes, 0, array1Decrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q.QuickSort(array1Decrescentes, 0, array1Decrescentes.Length - 1));
            Console.WriteLine("Quick Sort - 10000 - Decrescente Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos decrescentes
            Console.WriteLine("\nPressione qualquer tecla para iniciar - Bubble Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array2Decrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b.BubbleSort(array2Decrescentes));
            Console.WriteLine("Bubble Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Selection Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array2Decrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s.SelectionSort(array2Decrescentes));
            Console.WriteLine("Selection Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Insertion Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array2Decrescentes);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i.InsertionSort(array2Decrescentes));
            Console.WriteLine("Insertion Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Merge Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array2Decrescentes, 0, array2Decrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m.MergeSort(array2Decrescentes, 0, array2Decrescentes.Length - 1));
            Console.WriteLine("Merge Sort - 100000 - Decrescente Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Quick Sort - 100000 - Decrescente");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array2Decrescentes, 0, array2Decrescentes.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q.QuickSort(array2Decrescentes, 0, array2Decrescentes.Length - 1));
            Console.WriteLine("Quick Sort - 100000 - Decrescente Finalizado");

            //Execução das funções de ordenação com vetores de 10000 elementos aleatórios
            Console.WriteLine("\nPressione qualquer tecla para iniciar - Bubble Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Start();
            b.BubbleSort(array1BubbleRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b.BubbleSort(array1BubbleRandom));
            Console.WriteLine("Bubble Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Selection Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array1SelectionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s.SelectionSort(array1SelectionRandom));
            Console.WriteLine("Selection Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Insertion Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array1InsertionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i.InsertionSort(array1InsertionRandom));
            Console.WriteLine("Insertion Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Merge Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array1MergeRandom, 0, array1MergeRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m.MergeSort(array1MergeRandom, 0, array1MergeRandom.Length - 1));
            Console.WriteLine("Merge Sort - 10000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Quick Sort - 10000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array1QuickRandom, 0, array1QuickRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q.QuickSort(array1QuickRandom, 0, array1QuickRandom.Length - 1));
            Console.WriteLine("Quick Sort - 10000 - Aleatórios Finalizado");

            //Execução das funções de ordenação com vetores de 100000 elementos aleatórios 
            Console.WriteLine("\nPressione qualquer tecla para iniciar - Bubble Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            b.BubbleSort(array2BubbleRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(b.BubbleSort(array2BubbleRandom));
            Console.WriteLine("Bubble Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Selection Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            s.SelectionSort(array2SelectionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(s.SelectionSort(array2SelectionRandom));
            Console.WriteLine("Selection Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Insertion Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            i.InsertionSort(array2InsertionRandom);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(i.InsertionSort(array2InsertionRandom));
            Console.WriteLine("Insertion Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Merge Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            m.MergeSort(array2MergeRandom, 0, array2MergeRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(m.MergeSort(array2MergeRandom, 0, array2MergeRandom.Length - 1));
            Console.WriteLine("Merge Sort - 100000 - Aleatórios Finalizado");

            Console.WriteLine("\nPressione qualquer tecla para iniciar - Quick Sort - 100000 - Aleatórios");
            Console.ReadKey();
            st.Restart();
            q.QuickSort(array2QuickRandom, 0, array2QuickRandom.Length - 1);
            st.Stop();
            Console.WriteLine("Tempo de execução: " + st.ElapsedMilliseconds);
            Console.WriteLine(q.QuickSort(array2QuickRandom, 0, array2QuickRandom.Length - 1));
            Console.WriteLine("Quick Sort - 100000 - Aleatórios Finalizado");
            
            Console.WriteLine("\nPressione qualquer tecla para finalizar");

            Console.ReadKey();
        }
    }
}
