Console.WriteLine("Input nuber a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input nuber b");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b)
{
max = a;
}
else
{
max = b;
}
Console.WriteLine($"Bigger one is {max}");