using System;

public class maxmin
{
    public static void Main(string[] args)
    {
        int[] massiv = { 25, 16, 3, 2, 48, 56 };
        int minelement = massiv[0];
        int maxelement = massiv[0];
        for (int index = 1; index < massiv.Length; index++)
        {
            if (massiv[index] > maxelement)
                maxelement = massiv[index];
            if (massiv[index] < minelement)
                minelement = massiv[index];
        }
        Console.WriteLine($"eng katta element {maxelement}");
        Console.WriteLine($"eng kichik element {minelement}");
        Console.WriteLine($"katta va kichik elementlar ko`paytmasi = {maxelement * minelement}");
    }
}
