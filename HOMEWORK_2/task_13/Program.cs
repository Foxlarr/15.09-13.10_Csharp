Console.WriteLine("Input random number to see the third digit of it");
string input = Console.ReadLine();
if (input.Length < 3)
{
    Console.WriteLine("There is no 3rd digit");
}
else
{
Console.WriteLine("{0}->{1}",input, input[2]);
}