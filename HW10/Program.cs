using System;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = random.Next(100);
                Console.Write($"{arr[j]} ");
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine();
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.Read();
        }
    }
}