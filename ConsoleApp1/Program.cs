//•	Reads an integer number from the console
//•	Calculate sum of the factorials only on even digits of the given number
//•	Print the calculated sum

int result = int.Parse(Console.ReadLine());
int totalSum = 0;
while (result !=0)
{
    int digit = result % 10;
    if(digit % 2 == 0)
    {
        totalSum += CalculateFactoriel(digit);
    }
    result = result / 10;
}
Console.WriteLine(totalSum);
static int CalculateFactoriel (int number)
{
    int result = 1;
    while (number > 0)
    {
        result *= number;
        number--;
    }
    return result;
}