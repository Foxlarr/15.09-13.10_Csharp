Console.WriteLine("Wanna know if the first (a) number is a result of second one (b) rased to the power of 2?");
Console.WriteLine("Type first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type second number");
int b = Convert.ToInt32(Console.ReadLine());

if (b*b == a)
{
    Console.WriteLine($"Woah! You guessed it. Somehow. {a} is actually {b}^2");
}
else
{
    Console.WriteLine($"Nah,{a} isn't the result of {b}^2");
}