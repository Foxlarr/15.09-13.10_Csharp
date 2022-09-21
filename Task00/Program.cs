// 0 Демонстрация решения
// Напишите программу, которая
// 1. На вход принимает число и
// 2. выдаёт его квадрат (число, умноженное само на себя)
// Вывод результата
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.Write("input a number you want to exponate: ");
int number = Convert.ToInt32(Console.ReadLine());
int squear = number * number;

Console.WriteLine($"{number}^2 = {squear}");

// Math.Pow(number, 2);