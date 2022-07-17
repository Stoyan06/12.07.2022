using System;

public class Program
{
    public static void Main()
    {
        int waggonsCount = int.Parse(Console.ReadLine());
        int[] arr = new int[waggonsCount];
        int passengerCounter = 0;

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            Console.Write(arr[i] + " ");
        }

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            passengerCounter += arr[i];
        }

        Console.WriteLine();
        Console.WriteLine(passengerCounter);
    }
}
