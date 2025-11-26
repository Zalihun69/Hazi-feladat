using System;
using System.Collections.Generic;

public class Megoldas4
{
    public static void Futtat()
    {
        List<int> a = new List<int>(Listak.szamsorA);
        List<int> b = new List<int>(Listak.szamsorB);

        Buborek(a);
        Buborek(b);

        List<int> uj = Osszefesul(a, b);

        foreach (int x in uj)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    static void Buborek(List<int> lista)
    {
        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - i - 1; j++)
            {
                if (lista[j] > lista[j + 1])
                {
                    int tmp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = tmp;
                }
            }
        }
    }

    static List<int> Osszefesul(List<int> A, List<int> B)
    {
        List<int> eredmeny = new List<int>();
        int i = 0, j = 0;

        while (i < A.Count && j < B.Count)
        {
            if (A[i] < B[j])
            {
                eredmeny.Add(A[i]);
                i++;
            }
            else
            {
                eredmeny.Add(B[j]);
                j++;
            }
        }

        while (i < A.Count)
        {
            eredmeny.Add(A[i]);
            i++;
        }

        while (j < B.Count)
        {
            eredmeny.Add(B[j]);
            j++;
        }

        return eredmeny;
    }
}
