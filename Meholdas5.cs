using System;

public class Megoldas5
{
    public static void Futtat()
    {
        int db = 0;

        foreach (string s in Listak.tintapatronok)
        {
            if (s.Contains("Canon"))
                db++;
        }

        Console.WriteLine("Canon patronok száma: " + db);
    }
}
