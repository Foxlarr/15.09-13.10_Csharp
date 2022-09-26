/*Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

int[] array = new int[8];
int[] array1 = new int[8];
int[] array2 = {1,2,3,4,5,6,7};

var array3 = new int[8]; 
var rnd = new Random();

object[] array4 = new int[8];
*/
Console.Write("Input array length: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(x);
PrintArray(array);

int[] FillArray(int range)
{
    Random rnd = new Random();
    int[] array = new int[range];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,2);
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
