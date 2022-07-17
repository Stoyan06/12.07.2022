int numberOfOrders = int.Parse(Console.ReadLine());

double pricePerCapsule;

int daysInMonth;

int capsulesCount;

double totalPrice = 0;

double[] price = new double[numberOfOrders];

for (int i = 0; i < numberOfOrders; i++)
{
    pricePerCapsule = double.Parse(Console.ReadLine());
    daysInMonth = int.Parse(Console.ReadLine());
    capsulesCount = int.Parse(Console.ReadLine());
    price[i] = ((daysInMonth * capsulesCount) * pricePerCapsule);
    totalPrice += price[i];
}

for(int y = 0; y < price.Length; y++)
{
    Console.WriteLine("The price for the coffee is: ${0:f2}", price[y]);
}

Console.WriteLine("Total: ${0:f2}", totalPrice);