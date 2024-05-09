using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        string[] elements = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(elements[i]);
        }

        int b = int.Parse(Console.ReadLine());

        for (int i = b - 1; i < n - 1; i++)
        {
            array[i] = array[i + 1];
        }

        Array.Resize(ref array, n - 1);

        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
    }
}