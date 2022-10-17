// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


double[,,] CreateArray3D(int rows, int columns, int what, int min, int max)
{
    double[,,] matrix = new double[rows, columns, what];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            for (int z = 0; z < matrix.GetLength(2); z++) // 2 - what
            {
                matrix[i, j, z] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

bool FindElement(double[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(double[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}



System.Console.WriteLine("Type rows");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type columns");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type number for z");
int z = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


double[,,] array3D = CreateArray3D(row, column, z, -10, 10);
PrintArray(array3D);