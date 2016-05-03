using System;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            bubbleSort b = new bubbleSort();
            selectionSort s = new selectionSort();
            insertionSort i = new insertionSort();
            mergeSort m = new mergeSort();
            quickSort q = new quickSort();

            int[] arrayBubble = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayBubble2 = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayBubble3 = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arraySelection = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayInsertion = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayMerge = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayQuick = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };

            Console.WriteLine("Pressione qualquer tecla para iniciar");
            Console.ReadKey();

            st.Start();
            Console.WriteLine("Array inicial - Bubble Sort");
            Console.WriteLine(String.Join(" ", arrayBubble));
            b.BubbleSort(arrayBubble);
            st.Stop();
            
            Console.WriteLine("Tempo de execução Bubble Sort: " + st.ElapsedTicks);
            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Selection Sort");
            Console.WriteLine(String.Join(" ", arraySelection));
            s.SelectionSort(arraySelection);
            st.Stop();

            Console.WriteLine("Tempo de execução Selection Sort: " + st.ElapsedTicks);
            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Insertion Sort");
            Console.WriteLine(String.Join(" ", arrayInsertion));
            i.InsertionSort(arrayInsertion);
            st.Stop();

            Console.WriteLine("Tempo de execução Insertion Sort: " + st.ElapsedTicks);
            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Merge Sort");
            Console.WriteLine(String.Join(" ", arrayMerge));
            m.MergeSort(arrayMerge, 0, arrayMerge.Length - 1);
            st.Stop();

            Console.WriteLine("Tempo de execução Merge Sort: " + st.ElapsedTicks);
            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Quick Sort");
            Console.WriteLine(String.Join(" ", arrayQuick));
            q.QuickSort(arrayQuick, 0, arrayQuick.Length - 1);
            st.Stop();

            Console.WriteLine("Tempo de execução Quick Sort: " + st.ElapsedTicks);
            Console.ReadKey();
        }
    }
}
