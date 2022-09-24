Console.WriteLine("Type number of day (1 to 7), to to find out if it's a weekend or not.");
string a = Console.ReadLine();
switch (a)
{
    case "1":
        Console.WriteLine("no");
        break;
    case "2":
        Console.WriteLine("no");
        break;
    case "3":
        Console.WriteLine("no");
        break;
    case "4":
        Console.WriteLine("no");
        break;
    case "5":
        Console.WriteLine("no");
        break;
    case "6":
        Console.WriteLine("yes");
        break;
    case "7":
        Console.WriteLine("yes");
        break;
    default:
    Console.WriteLine("Your input was not the numbers from 1 to 7.");
    break;
}