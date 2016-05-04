using System;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            Random rnd = new Random();

            bubbleSort b = new bubbleSort();
            selectionSort s = new selectionSort();
            insertionSort i = new insertionSort();
            mergeSort m = new mergeSort();
            quickSort q = new quickSort();

            long tempoBubble;
            long tempoSelection;
            long tempoInsertion;
            long tempoMerge;
            long tempoQuick;

            int tamanhoArray = 10000;

            int[] arrayBubble = new int[tamanhoArray]; 
            for (int y = 0; y < arrayBubble.Length; y++)
            {
                arrayBubble[y] = rnd.Next();
            }

            int[] arraySelection = new int[tamanhoArray];
            for (int y = 0; y < arraySelection.Length; y++)
            {
                arraySelection[y] = rnd.Next();
            }

            int[] arrayInsertion = new int[tamanhoArray];
            for (int y = 0; y < arrayInsertion.Length; y++)
            {
                arrayInsertion[y] = rnd.Next();
            }

            int[] arrayMerge = new int[tamanhoArray];
            for (int y = 0; y < arrayMerge.Length; y++)
            {
                arrayMerge[y] = rnd.Next();
            }

            int[] arrayQuick = new int[tamanhoArray];
            for (int y = 0; y < arrayQuick.Length; y++)
            {
                arrayQuick[y] = rnd.Next();
            }

            Console.WriteLine("Pressione qualquer tecla para iniciar");
            Console.ReadKey();

            st.Start();
            Console.WriteLine("Array inicial - Bubble Sort");
            Console.WriteLine(String.Join(" ", arrayBubble));
            b.BubbleSort(arrayBubble);
            st.Stop();
            tempoBubble = st.ElapsedTicks;
            
            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Selection Sort");
            Console.WriteLine(String.Join(" ", arraySelection));
            s.SelectionSort(arraySelection);
            st.Stop();
            tempoSelection = st.ElapsedTicks;

            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Insertion Sort");
            Console.WriteLine(String.Join(" ", arrayInsertion));
            i.InsertionSort(arrayInsertion);
            st.Stop();
            tempoInsertion = st.ElapsedTicks;

            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Merge Sort");
            Console.WriteLine(String.Join(" ", arrayMerge));
            m.MergeSort(arrayMerge, 0, arrayMerge.Length - 1);
            st.Stop();
            tempoMerge = st.ElapsedTicks;

            Console.ReadKey();

            st.Restart();
            Console.WriteLine("\nArray inicial - Quick Sort");
            Console.WriteLine(String.Join(" ", arrayQuick));
            q.QuickSort(arrayQuick, 0, arrayQuick.Length - 1);
            st.Stop();
            tempoQuick = st.ElapsedTicks;

            Console.ReadKey();

            Console.WriteLine("Tempo de execução: ");

            Console.WriteLine("\nTempo de execução Bubble Sort: " + tempoBubble);
            Console.WriteLine("Tempo de execução Selection Sort: " + tempoSelection);
            Console.WriteLine("Tempo de execução Insertion Sort: " + tempoInsertion);
            Console.WriteLine("Tempo de execução Merge Sort: " + tempoMerge);
            Console.WriteLine("Tempo de execução Quick Sort: " + tempoQuick);

            Console.ReadKey();
        }
    }
}
