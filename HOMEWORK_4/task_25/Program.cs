Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input power ");
double pow = Convert.ToDouble(Console.ReadLine());
int res = 1;
 
int RaiseToPower (int Rnum, double Rpow, int Rres)
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