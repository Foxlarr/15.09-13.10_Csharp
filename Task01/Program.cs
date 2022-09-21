Console.WriteLine("Type number of day (1 to 7)");
string a = Console.ReadLine();
string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
switch (a)
{
    case "1":
        Console.WriteLine(weekDays[0]);
        break;
    case "2":
        Console.WriteLine(weekDays[1]);
        break;
    case "3":
        Console.WriteLine(weekDays[2]);
        break;
    case "4":
        Console.WriteLine(weekDays[3]);
        break;
    case "5":
        Console.WriteLine(weekDays[4]);
        break;
    case "6":
        Console.WriteLine(weekDays[5]);
        break;
    case "7":
        Console.WriteLine(weekDays[6]);
        break;
    default:
    Console.WriteLine("There are only 7 days, you dumb coconut. They also can't be negative. Try again. And don't you dare type anything other than numbers. ");
    break;
}











/*Console.WriteLine("Type number of day (1 to 7)");
int a = Convert.ToInt32(Console.ReadLine());
string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};


    if (a>7 | a<0)
        {
            Console.WriteLine("There are only 7(seven) days, you dumb coconut. They also can't be negative. Try again.");
        }
            else
        {
            Console.WriteLine(weekDays[a]);
        }

*/