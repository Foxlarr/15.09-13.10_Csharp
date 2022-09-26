Console.WriteLine("Type numbers");
int number = Convert.ToInt32(Console.ReadLine());

int makeFactorial (int num)
{
    if (num < 0) num = -num;
    
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *=  i;
    }
    return factorial;
}

int result = makeFactorial(number);
Console.WriteLine($"factorial of {number} is {result}");