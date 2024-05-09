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
                if (arr[i] < arr[i+1])
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
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        string[] elements = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(elements[i]);
        }
        int x = int.Parse(Console.ReadLine());
        int counter = 0;
        BubbleSort(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (x <= array[i])
            {
                counter = i+1;
            }
        }
        Console.WriteLine(counter+1);
       
    }

}