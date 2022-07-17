int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int numberOfRotations = int.Parse(Console.ReadLine());
int memory = 0;

for(int i = 0; i < numberOfRotations; i++)
{
    memory = arr[0];

    for(int y = 1; y <= arr.Length - 1; y++)
    {
        arr[y - 1] = arr[y];
    }

    arr[arr.Length - 1] = memory;
}

Console.WriteLine(String.Join(" ", arr));