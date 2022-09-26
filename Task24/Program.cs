Console.WriteLine("Type numbers");
int number = Convert.ToInt32(Console.ReadLine());
int sumnumbers = SumNumbers(number);
Console.WriteLine($"Sum of numbers from 1 to {number} = {sumnumbers}");


int SumNumbers (int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}


int SumNumbers2 (int num)
{
    int sum = default;
    int counter = 1;
    while (counter  <= num)
    {
        //sum = sum + i;
        sum += counter;
        counter ++;    
    }
    return sum;
}