double[,] CreateMatrixRndDoub(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}



void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

System.Console.WriteLine("Type rows");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type columns");
int column = Convert.ToInt32(Console.ReadLine());

double[,] array2D = CreateMatrixRndDoub(row, column, -10, 10);
PrintMatrix(array2D);