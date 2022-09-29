Console.WriteLine("Input first coords");
Console.Write("X1 :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second coords");
Console.Write("X2 :");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());

double LengthOfLine (int mx1, int mx2, int my1, int my2)
{
if (x1 == x2 && y1 == y2) return 0;
int a = x1 - x2;
int b = y1 - y2;
return Math.Sqrt(Math.Pow(a , 2) + Math.Pow(b , 2));
}

double distanse = LengthOfLine(x1, x2, y1, y2);
double res = Math.Round(distanse, 2, MidpointRounding.ToZero);
System.Console.WriteLine(res);