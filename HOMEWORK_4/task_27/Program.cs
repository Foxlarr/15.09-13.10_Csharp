Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
string notnum = Convert.ToString(num); 

        int Sum (int Snum)
        {
            int res = 0;
            for (int i = 0; i < notnum.Length; i++)
           {
            res += Snum % 10;
            Snum /= 10;
           }
           
            return res;
        }
int res = Sum(num);
    if (num < 0) res = -res;

Console.WriteLine($"{num} => {res}");