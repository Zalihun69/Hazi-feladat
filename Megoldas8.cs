using System;
using System.Collections.Generic;

public class Megoldas8
{
    public static void Futtat()
    {
        Dictionary<char, int> db = new Dictionary<char, int>();

        foreach (char c in Listak.jelek)
        {
            if (!db.ContainsKey(c))
                db[c] = 0;

            db[c]++;
        }

        char legtobb = '?';
        int max = -1;

        foreach (var elem in db)
        {
            if (elem.Value > max)
            {
                max = elem.Value;
                legtobb = elem.Key;
            }
        }

        Console.WriteLine("Legtöbb jel: " + legtobb);
    }
}
