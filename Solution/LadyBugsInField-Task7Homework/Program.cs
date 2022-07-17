//!!The program will work only with correct inputs!!
int sizeOfTheField = int.Parse(Console.ReadLine());

bool[] positions = new bool[sizeOfTheField];//if the position is available-true, else-false
for(int i = 0; i < sizeOfTheField; i++)
{
    positions[i] = true;//makes all the positions available
}

string input;

bool help = true;

while ((input = Console.ReadLine()) != "end")
{
    int ladyBugCurrentPosition = int.Parse(input.Split()[0]);
    string directionOfMovement = input.Split()[1];
    int steps = int.Parse(input.Split()[2]);

    if(directionOfMovement == "left")
    {

        if (ladyBugCurrentPosition - steps < 0)
        {
            positions[ladyBugCurrentPosition] = true;
            help = false;
        }
        if (help == true)
        {
            if (positions[ladyBugCurrentPosition - steps] = false)
            {
                while (positions[ladyBugCurrentPosition - steps] = false)
                {
                    steps++;
                }
            }
            positions[ladyBugCurrentPosition - steps] = false;
            positions[ladyBugCurrentPosition] = true;
        }
    }

    if (directionOfMovement == "right")
    {
        if (ladyBugCurrentPosition + steps > sizeOfTheField - 1)
        {
            positions[ladyBugCurrentPosition] = true;
            help = false;
        }
        if (help == true)
        {
            if (positions[ladyBugCurrentPosition + steps] = false)
            {
                while (positions[ladyBugCurrentPosition + steps] = false)
                {
                    steps++;
                }
            }

            positions[ladyBugCurrentPosition + steps] = false;
            positions[ladyBugCurrentPosition] = true;
        }
    }
    help = true;
}

for(int i = 0; i < sizeOfTheField; i++)
{
    if (positions[i] == true)
    {
        Console.Write(0 + " ");
    }
    else
    {
        Console.Write(1 + " ");
    }
}