Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input power ");
int pow = Convert.ToInt32(Console.ReadLine());
int res = 1;

int RaiseToPower (int Rnum, int Rpow, int Rres)
{
        
        for (int i = 0; i < Rpow; i++)
        {
        res *= Rnum;
        }
    return res;
}

int fres = RaiseToPower(num, pow, res);
if (num < 0) fres = -fres;
System.Console.WriteLine(fres);