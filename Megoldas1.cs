using System;

public class Megoldas1
{
    public static void Futtat()
    {
        int oddA = 0;
        foreach (int x in Listak.szamsorA)
        {
            if (x % 2 != 0) oddA++;
        }

        int oddB = 0;
        foreach (int x in Listak.szamsorB)
        {
            if (x % 2 != 0) oddB++;
        }

        if (oddA > oddB) Console.WriteLine("szamsorA-ban van több páratlan szám");
        else if (oddA < oddB) Console.WriteLine("szamsorB-ben van több páratlan szám");
        else Console.WriteLine("A két lista páratlan számok száma megegyezik");
    }
}
