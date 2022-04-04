using System;
using System.Collections;

public class Scramblies
{
    public static int countOcc(string word, char c)
    {
        if (!word.Contains(c)) return 0;

        int count = 0;
        foreach (char c2 in word)
        {
            if (c2.Equals(c)) count++;
        }
        return count;
    }

    public static bool Scramble(string str1, string str2)
    {
        Hashtable ht = new Hashtable();
        foreach (char c in str1)
        {
            ht[c] = countOcc(str1, c);
        }

        foreach (char c in str2)
        {
            if (!ht.ContainsKey(c)) return false;
            int minimalOcc = countOcc(str2, c); //kolku pati se pojavuva vo vtoriot zbor
            int availableOcc = (int)ht[c];

            if (availableOcc < minimalOcc) return false;
        }
        return true;
    }

}