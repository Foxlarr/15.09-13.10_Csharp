Console.WriteLine("Input nuber a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input nuber b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number c");
int c = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

array[0] = a;
array[1] = b;
array[2] = c;

int max = a;

for (int i = 0; i < array.Length; i++) 
{
    if (array[i] > max)
    {
        max = array[i];
    }
   
}

Console.WriteLine($"Bigger one is {max}");