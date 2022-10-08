Console.WriteLine("k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b2");
double b2 = Convert.ToInt32(Console.ReadLine());

string FindTheSpot(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*((b2 - b1)/(k1 - k2))+b1;
    return ($"{x},{y}");
}
string y = FindTheSpot(k1, b1, k2, b2);
System.Console.WriteLine($"intersection point coordinates are {y}");