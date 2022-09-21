Console.WriteLine("Type number");
int a = Convert.ToInt32(Console.ReadLine());
if (a>0)
{
for (int i = 1; i <= a; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
}
else
{
    for (int i = -1; i >= a; i--)
    if (i % 2 == 0)
        Console.WriteLine(i);
}