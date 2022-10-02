Console.Write("Input number ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input power ");
double pow = Convert.ToDouble(Console.ReadLine());
double res = 1;
 
double RaiseToPower (double Rnum, double Rpow, double Rres)
{
        if (pow < 0) Rpow = -Rpow;
        for (int i = 0; i < Rpow; i++)
        {
        res *= Rnum;
        }
    return res;
}

double fres = RaiseToPower(num, pow, res);
if (pow < 0) fres = 1 / fres; 
if (num < 0) fres = -fres;
//fres = Math.Round(fres, 5, MidpointRounding.ToZero);
System.Console.WriteLine(fres);