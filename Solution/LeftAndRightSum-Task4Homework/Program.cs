int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
if(arr.Length == 1)
{
    Console.WriteLine(0);
    return;
}

int leftSum = 0;
int rightSum = 0;

for(int i = 1; i < arr.Length - 1; i++)
{
    for(int y = 0; y < i; y++)
    {
        leftSum += arr[y];
    }

    for(int z = i + 1; z < arr.Length; z++)
    {
        rightSum += arr[z];
    }

    if(leftSum == rightSum)
    {
        Console.WriteLine(i);
        return;
    }

    leftSum = 0;
    rightSum = 0;
}

Console.WriteLine("no");