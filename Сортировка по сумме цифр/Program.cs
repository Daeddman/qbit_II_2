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
                int sum1 = CalculateDigitSum(arr[i]);
                int sum2 = CalculateDigitSum(arr[i + 1]);
                if (sum1 > sum2 || (sum1 == sum2 && arr[i] > arr[i+1]))
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
                
            }

            n--;

        } while (swapped);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        string[] elements = Console.ReadLine().Split();

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(elements[i]);
        }

        BubbleSort(array);
        
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    static int CalculateDigitSum(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return Math.Abs(sum);
    }
}