// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void AllNatural(int num)
{
    System.Console.Write($"{num} ");
    if (num != 1) AllNatural(num - 1);
}

System.Console.WriteLine("input n");
int num = Convert.ToInt32(Console.ReadLine());
AllNatural(num);
