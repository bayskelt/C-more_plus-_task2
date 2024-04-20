using System;

namespace C__more_plus__task2
{
    internal class Program
    {
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            int comparisons = 0;
            int swaps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    comparisons++;
                    if (array[j] > array[j + 1])
                    {
                        swaps++;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            PrintArray(array, swaps, comparisons);
        }

        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            int comparisons = 0;
            int swaps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    comparisons++;
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    swaps++;
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
            PrintArray(array, swaps, comparisons);
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            int comparisons = 0;
            int swaps = 0;
            for (int i = 1; i < n; i++)
            {
                int current = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    comparisons++;
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
                swaps++;
            }
            PrintArray(array, swaps, comparisons);
        }

        static void PrintArray(int[] array, int swaps, int comparisons)
        {
            Console.Write("{ ");
            foreach (int i in array)
            {
                Console.Write($"{i}; ");
            }
            Console.Write("} ");
            Console.Write($"| Кiлькiсть обмiнiв: {swaps} | Кiлькiсть порiвнянь: {comparisons}\n");
        }

        static void Main(string[] args)
        {
            int[] mas1 = { 57, 23, 81, 42, 69, 34, 78, 15 };
            int[] mas2 = { 12, 32, 21, 41, 53, 95, 67, 78 };
            int[] mas3 = { 98, 87, 75, 63, 52, 43, 31, 19 };

            Console.WriteLine("Масиви вiдсортованi методом простого обмiну:");
            Console.Write("Невiдсортований масив: ");
            BubbleSort((int[])mas1.Clone());
            Console.Write("Майже вiдсортований масив: ");
            BubbleSort((int[])mas2.Clone());
            Console.Write("Вiдсортований масив у порядку спадання: ");
            BubbleSort((int[])mas3.Clone());

            Console.WriteLine("\nМасиви вiдсортованi методом простого вибору:");
            Console.Write("Невiдсортований масив: ");
            SelectionSort((int[])mas1.Clone());
            Console.Write("Майже вiдсортований масив: ");
            SelectionSort((int[])mas2.Clone());
            Console.Write("Вiдсортований масив у порядку спадання: ");
            SelectionSort((int[])mas3.Clone());

            Console.WriteLine("\nМасиви вiдсортованi методом простої вставки:");
            Console.Write("Невiдсортований масив: ");
            InsertionSort((int[])mas1.Clone());
            Console.Write("Майже вiдсортований масив: ");
            InsertionSort((int[])mas2.Clone());
            Console.Write("Вiдсортований масив у порядку спадання: ");
            InsertionSort((int[])mas3.Clone());
        }
    }
}