
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min,max +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i == array.Length - 1)  Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    System.Console.Write("]");
}

int SumOfOdd(int[] array)
{
    int sum = default;
    for (int i = 1; i < array.Length; i+=2 )
    {
        sum = sum + array[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);
int sum = SumOfOdd(array);
System.Console.WriteLine($" -> {sum}");

