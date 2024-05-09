using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int[][] timeMoments = new int[n][];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int hours = int.Parse(input[0]);
            int minutes = int.Parse(input[1]);
            int seconds = int.Parse(input[2]);

            timeMoments[i] = new int[] { hours, minutes, seconds };
        }

        SelectionSort(timeMoments);
        int x = 1;
        foreach (int[] moment in timeMoments)
        {
            Console.WriteLine($"{moment[0]} {moment[1]} {moment[2]}");
        }
    }

    static void SelectionSort(int[][] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (Compare(arr[j], arr[minIndex]) < 0)
                {
                    minIndex = j;
                }
                
            }

            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
            
        }

    }
    static int Compare(int[] a, int[] b)
    {
        if (a[0] != b[0]) return a[0].CompareTo(b[0]);
        if (a[1] != b[1]) return a[1].CompareTo(b[1]);
        return a[2].CompareTo(b[2]);
    }
}