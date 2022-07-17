int rowCounter = int.Parse(Console.ReadLine());

int[] arr1 = new int[rowCounter];
int[] arr2 = new int[rowCounter];

for(int i = 0; i < rowCounter; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if(i % 2 == 0)
    {
         arr1[i] = input[0];
         arr2[i] = input[1];
    }
    else
    {
        arr1[i] = input[1];
        arr2[i] = input[0];
    }
}

Console.WriteLine(String.Join(" ", arr1));
Console.WriteLine(String.Join(" ", arr2));