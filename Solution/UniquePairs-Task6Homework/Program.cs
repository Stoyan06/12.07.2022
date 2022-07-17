int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int index = int.Parse(Console.ReadLine());

for(int i = 0; i < arr.Length; i++)
{
    for(int y = i + 1; y < arr.Length; y++)
    {
          if (arr[i] + arr[y] == index)
          {
            Console.Write(arr[i] + " " + arr[y] + " ");
            Console.WriteLine();
          }
    }
}