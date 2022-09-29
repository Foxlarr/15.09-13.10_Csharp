Console.WriteLine("Input quarter");
int quaterNum = Convert.ToInt32(Console.ReadLine());

string range = FindRange(quaterNum);

Console.WriteLine(range);

string FindRange (int num)
{
    if (num == 1) return "x = from 1 to inf and y from 1 to inf";
    if (num == 2) return "x = from -1 to -inf and y from 1 to inf";
    if (num == 3) return "x = from -1 to -inf and y from -1 to -inf";
    if (num == 4) return "x = from 1 to inf and y from -1 to -inf";
    return "Input incorrect";
}