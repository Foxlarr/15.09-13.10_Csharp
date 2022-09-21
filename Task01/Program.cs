Console.WriteLine("Type number of day (1 to 7)");
int a = Convert.ToInt32(Console.ReadLine());
string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

if (a>7)
{
    Console.WriteLine("There are only 7(seven) days, you dumb coconut. Try again.");
}
else
{
Console.WriteLine(weekDays[a]);
}

