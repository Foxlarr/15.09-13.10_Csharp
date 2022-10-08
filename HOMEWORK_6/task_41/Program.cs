Console.Write("Input nums (use space to sepparate): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Count of nums > 0 -> {count}");