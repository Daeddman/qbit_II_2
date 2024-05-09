using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }

            n--;

        } while (swapped);
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] elements = Console.ReadLine().Split();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(elements[i]);
        }
        BubbleSort(array);
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int el in arr)
        {
            Console.Write($"{el} ");
        }
        
    }
    
}