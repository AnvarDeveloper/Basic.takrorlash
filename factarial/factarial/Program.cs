
//3-masala   ixtiyoriy x sonining faktarialini topish

using System;

public class factarial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1 dan 25 gacha bulgan ixtiyoriy musbat son kiriting");
        int x = Convert.ToInt32(Console.ReadLine());
        long fact = 1;
        for (long i = 1; i <= x; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine($"{x} sonining faktariali = {fact}");
    }
}
