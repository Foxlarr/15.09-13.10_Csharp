
double[] CreateArrayRndDouble(int size, int min, int max)
{
    
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i == array.Length - 1)  Console.Write($"{Math.Round(array[i],3)}");
        else Console.Write($"{Math.Round(array[i],3)}, ");
    }
    System.Console.Write("]");
}

double DiffBetweenMinMax(double[] array)
{
    double sum = default;
    double max = double.NegativeInfinity;
    double min = double.PositiveInfinity;
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = Math.Round ( array[i], 3);
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    sum = min + max;
    return sum;
}



double[] array = CreateArrayRndDouble(3, 1, 10);
PrintArray(array);
double sum = DiffBetweenMinMax(array);
System.Console.WriteLine($" -> {sum}");

