using System;

class Program
{
    static int SelectionSort(int[] arr)
    {
        long firstElement = arr[0];
        int counter = 0;
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
                
            }
            (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);

            if ((arr[minIndex] == firstElement) || minIndex != i)
            {
                counter++;
            }
        }

        return counter;

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
        int counter = SelectionSort(array);
        Console.WriteLine(counter);
        
    }

    static void PrintArray(int[] arr)
    {
        foreach (int el in arr)
        {
            Console.Write($"{el} ");
        }
    }
}