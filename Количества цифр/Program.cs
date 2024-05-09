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
                if (arr[i] > arr[i + 1] && arr[i + 1] != 0)
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
        string input = Console.ReadLine();
        int[] array = Array.ConvertAll(input.Split(), int.Parse);
        
        BubbleSort(array);
        int[] counters = new int[10];
        
        for (int i = 0; i < array.Length; i++)
        {
            counters[array[i]]++;
        }
        
        for (int i = 1; i < counters.Length; i++)
        {
            Console.Write(counters[i] + " ");
        }
    }
}