Console.Write("Input power ");
double pow = Convert.ToDouble(Console.ReadLine());
Console.Write("Input amount ");
int num = Convert.ToInt32(Console.ReadLine());
RaiseToPower(num, pow);

void RaiseToPower (double num, double pow)
{
    if (num>0)
    { 
        for (int i = 1; i <= num; i++)
        {
        System.Console.WriteLine($"{i} {Math.Pow(i , pow)}");
        }
        
    }
    else System.Console.WriteLine("negative amount");
}
