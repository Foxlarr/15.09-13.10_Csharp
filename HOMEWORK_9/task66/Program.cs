// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int AllNatural(int m, int n)
{
    int res = n;
    
    if (m != n) res = n + AllNatural(m , n - 1);
    System.Console.WriteLine($"m {m}, n {n}, res {res}"); 
  
    return res;
}

System.Console.WriteLine("input m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input n");
int n = Convert.ToInt32(Console.ReadLine());
if (m>n) (m, n) = (n, m);
int res = AllNatural(m,n);
System.Console.WriteLine(res);