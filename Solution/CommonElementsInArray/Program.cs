using System;


public class Program
{
    public static void Main()
    {
        string firstLine = Console.ReadLine();
        string SecondLine = Console.ReadLine();

        string[] arr1 = firstLine.Split();
        string[] arr2 = SecondLine.Split();

        for (int i = 0; i < arr1.Length; i++)
        {


            if (arr2.Contains(arr1[i]))
            {
                Console.Write(arr1[i] + " ");
            }
            //for(int y = 0; y<arr2.Length;y++){

            //  if(arr1[i] == arr2[y]){
            // Console.Write(arr1[i] + " ");
            //  }

        }

    }


}
