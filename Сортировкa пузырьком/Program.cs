using System;

class Program
{
    /*static void BubbleSort(int[] arr)
    {
        int counter = 0;
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
                    counter++;
                }
            }
        } while (swapped);
        
    }*/
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] elements = Console.ReadLine().Split();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(elements[i]);
        }
        int counter = 0;
        int x = array.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < x - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    swapped = true;
                    counter++;
                }
            }
        } while (swapped);

        Console.WriteLine(counter);
    }
}