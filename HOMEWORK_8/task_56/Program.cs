// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

double SumOfRow(double[,] matrix, int i)
{

    double sumres = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumres += matrix[i, j];
    }
    return sumres;

}


System.Console.WriteLine("Type rows");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type columns");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


double[,] array2D = CreateMatrixRndDoub(row, column, -10, 10);
PrintMatrix(array2D);
double line = SumOfRow(array2D, 0);

//this shoud be some kind of method...
double numLine = 0;
for (int i = 1; i < array2D.GetLength(0); i++)
{
  double tempSumLine = SumOfRow(array2D, i);
  if (line > tempSumLine)
  {
    line = tempSumLine;
    numLine = i;
  }
}

System.Console.WriteLine();
System.Console.WriteLine($"row with smallest sum of elems is {numLine+1}");
