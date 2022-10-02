Console.Write("Input array length: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive randomness FROM diapason ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive randomness TO diapason: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size);
PrintArray(array);

int[] FillArray(int range)
{
    Random rnd = new Random();
    int[] array = new int[range];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(a,b);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i == array.Length - 1)  Console.Write($"{array[i]}");
        else Console.Write($"{array[i]},");
    }
    System.Console.Write("]");
}