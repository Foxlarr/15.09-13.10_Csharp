// FIRST ONE
Console.WriteLine("Input random number to see the second digit of it");
int a = Convert.ToInt32(Console.ReadLine());
int n = 0;
if (a < 0)
{
  a = -a ;
}
while (a > 100)
{
  a = (a / 10);
}
n = (a % 10);
Console.WriteLine (n);

// SECOND ONE

// Console.WriteLine("Input random number to see the second digit of it");
// string input = Console.ReadLine();
// Console.WriteLine("{0}->{1}",input, input[1]);