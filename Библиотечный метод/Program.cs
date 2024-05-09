using System;

class Program
{
    static void InsertionSortMethod(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
            if (i > 1 || arr.Length < 3)
            {
                PrintArray(arr);
            }
        }
        
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

        if (array.Length > 1 && IsSorted(array) == true)
        {
            Console.WriteLine("The array is already sorted");
        }
        else
        {
            InsertionSortMethod(array);
        }
        
    }

    static bool IsSorted(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i + 1] < arr[i])
            {
                return false;
            }
        }

        return true;
    }

    static void PrintArray(int[] arr)   
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}