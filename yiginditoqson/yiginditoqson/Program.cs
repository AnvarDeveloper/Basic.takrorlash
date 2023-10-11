using System;

public class summatoqson
{
    public static void Main(string[] args)
    {
        int i = 1;
        int summa = 0;
        while (i <= 1000)
        {
            if (i % 2 != 0)
                summa = summa + i;
            i++;
        }
        Console.WriteLine($"1 dan 1000 gacha bo`lgan toq sonlar yigindisi = {summa}");
    }
}