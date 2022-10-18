﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int FAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return FAkkerman(m - 1, 1);
    }
    return FAkkerman(m - 1, FAkkerman(m, n - 1));
}

System.Console.WriteLine("input m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FAkkerman(m, n));