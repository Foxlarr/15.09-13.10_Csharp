
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

int CountOfEven(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    return sum;
}


int[] array = CreateArrayRndInt(4, 100, 999);
PrintArray(array);
int sum = CountOfEven(array);
System.Console.WriteLine($" -> {sum}");

