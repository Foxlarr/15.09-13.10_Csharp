Console.WriteLine("Input 5digits number to see if it's palindrome");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 100000 && x > 9999)
{
    int a1 = x % 10;
    int a2 = x / 10 % 10;
    int a3 = x / 100 % 10;
    int a4 = x / 1000 % 10;
    int a5 = x / 10000;
    int y = a1 * 10000 + a2*1000 + a3*100 + a4*10 +a5;
    if (x == y) 
    System.Console.WriteLine($"{x} -> yes");
    else System.Console.WriteLine($"{x} -> no");
}
else
{
    System.Console.WriteLine("5 digits needed");
}
