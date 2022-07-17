int lostGames = int.Parse(Console.ReadLine());
double headSetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

double expenses = 0;

int crashedHeadSetTimes = 0;
int crashedMouseTimes = 0;
int crashedKeyboardTimes = 0;
int crashedDisplayTimes = 0;

int crashedKeyboardTimesTotal = 0;

bool help = false;//helps to detect when are both the headset and the mouse crashed in the same game!


for (int i = 1; i <= lostGames; i++)//7
{
    if(i % 2 == 0)
    {
        crashedHeadSetTimes++;
        help = true;
    }

    if (i % 3 == 0)
    { 
            crashedMouseTimes++;
        if (help == true)
        {
            crashedKeyboardTimesTotal++;
            crashedKeyboardTimes++;
        }
    }

    if (crashedKeyboardTimes == 2)
    {
        crashedDisplayTimes++;
        crashedKeyboardTimes = 0;
    }

    help = false;
}

expenses = headSetPrice * crashedHeadSetTimes + mousePrice * crashedMouseTimes + keyboardPrice * crashedKeyboardTimesTotal + displayPrice * crashedDisplayTimes;

Console.WriteLine("Rage expenses: {0:f2} lv.",expenses);