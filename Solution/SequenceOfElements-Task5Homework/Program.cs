int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();//2 1 1 2 3 3 2 2 2 1
int count = 1;
int max = 0;
int currentNumber = 0;

for(int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] == arr[i + 1])
    {
        count++;
    }
    else
    {
        count = 1;
    }

    if (max < count)
    {
        max = count;
        currentNumber = arr[i];    
    }
}

 for (int x = 0; x < max; x++)
{
    Console.Write(currentNumber + " ");
}