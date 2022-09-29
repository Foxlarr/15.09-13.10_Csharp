Console.WriteLine("Input first coords");
Console.Write("X1 :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 :");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second coords");
Console.Write("X2 :");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 :");
int z2 = Convert.ToInt32(Console.ReadLine());


double LengthOfLine3D (int mx1, int mx2, int my1, int my2, int mz1, int mz2)
{
if (x1 == x2 && y1 == y2 && z1 == z2 ) return 0;
int a = x1 - x2;
int b = y1 - y2;
int c = z1 - z2;

return Math.Sqrt(Math.Pow(a , 2) + Math.Pow(b , 2) + Math.Pow(c , 2));
}

double distanse = LengthOfLine3D(x1, x2, y1, y2, z1 ,z2);
double res = Math.Round(distanse, 2, MidpointRounding.ToZero);
System.Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {res}");