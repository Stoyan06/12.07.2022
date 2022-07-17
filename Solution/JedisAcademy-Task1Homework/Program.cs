double budjet = double.Parse(Console.ReadLine());

int countOfStudents = int.Parse(Console.ReadLine());

double priceOfLightsabers = double.Parse(Console.ReadLine());

double priceOfRobes = double.Parse(Console.ReadLine());

double priceOfBelts = double.Parse(Console.ReadLine());

int help = 0;
int freeBelts = 0;
while(help + 6 <= countOfStudents)
{
    help += 6;
    freeBelts++;
}

double totalLightsabresCount = countOfStudents * 1.10;
if(totalLightsabresCount * 10 % 10 < 5)//12,3
{
    totalLightsabresCount++;
    totalLightsabresCount = Math.Round(totalLightsabresCount);
}
else if(totalLightsabresCount * 10 % 10 == 5)//12,5
{
    totalLightsabresCount++;
    totalLightsabresCount = Math.Round(totalLightsabresCount);
}
else if(totalLightsabresCount * 10 % 10 > 5)//12,7
{
    totalLightsabresCount = Math.Round(totalLightsabresCount);
}

double totalSum = priceOfLightsabers * totalLightsabresCount + priceOfRobes * countOfStudents + priceOfBelts * (countOfStudents - freeBelts);

if(totalSum < budjet)
{
    Console.WriteLine("The money is enough - it will cost {0:f2}lv.",totalSum);
}
else
{
    Console.WriteLine("John will need {0:f2} more lv.", totalSum - budjet);
}