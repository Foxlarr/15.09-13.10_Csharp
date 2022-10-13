// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

object FindElem(double[,] matrix, int i, int j)
{
   if (matrix.GetLength(0)-1 < i | matrix.GetLength(1)-1 < j) return "404 element not found here";
   else return matrix[i,j];
}

System.Console.WriteLine("Type rows");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type columns");
int column = Convert.ToInt32(Console.ReadLine());

double[,] array2D = CreateMatrixRndDoub(row, column, -10, 10);
PrintMatrix(array2D);

System.Console.WriteLine("Type row");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type column");
int column1 = Convert.ToInt32(Console.ReadLine());
object res = FindElem(array2D, row1-1, column1-1);
Console.WriteLine(res);