// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


double[,] CreateMatrixRndDoub(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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


double[,] MultiplyMatrix(double[,] first, double[,] second)
{

if (first.GetUpperBound(0) != second.GetUpperBound(1)) throw new Exception("Rows from first matrix MUST be equal with columns from third matrix");

    double[,] result = new double[first.GetUpperBound(0) + 1, second.GetUpperBound(1) + 1];

    for (var i = 0; i < first.GetUpperBound(0) + 1; i++)
    {
        for (var j = 0; j < second.GetUpperBound(1)+1; j++)
        {
            result[i, j] = 0;

            for (var k = 0; k < first.GetUpperBound(1)+1; k++)
            {
                result[i, j] += first[i, k] * second[k, j];
            }
        }
    }
    return result;
}


System.Console.WriteLine("Type rows for the first");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type columns for the first");
int column1 = Convert.ToInt32(Console.ReadLine());

double[,] array2D = CreateMatrixRndDoub(row1, column1, 0, 3);
PrintMatrix(array2D);
System.Console.WriteLine();
System.Console.WriteLine("Type rows for the second");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type columns for the second");
int column2 = Convert.ToInt32(Console.ReadLine());
double[,] array2D2 = CreateMatrixRndDoub(row2, column2, 0, 3);
PrintMatrix(array2D2);



var res = MultiplyMatrix(array2D, array2D2);

System.Console.WriteLine();
System.Console.WriteLine("Result of matrix multipy");
PrintMatrix(res);

