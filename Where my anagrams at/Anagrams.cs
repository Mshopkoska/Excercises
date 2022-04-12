using System;
using System.Collections.Generic;
using System.Collections;
/*
public static class Kata
{
    public static Boolean isAnagram(String word1, String word2)
    {
        if (word1.Length != word2.Length) return false;

        Hashtable ht = new Hashtable();
        foreach (char c in word1)
        {
            ht[c] = countOcc(word1, c);
        }

        foreach (char c in word2)
        {
            if (!ht.ContainsKey(c)) return false;

            int minimalOcc = countOcc(word2, c); //kolku pati se pojavuva vo vtoriot zbor
            int availableOcc = (int)ht[c];
            if (availableOcc != minimalOcc) return false;
        }
        return true;
    }
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

    public static List<string> Anagrams(string word, List<string> words)
    {
        List<String> resultList = new List<string>();
        foreach (string w in words)
        {
            if (isAnagram(word, w)) resultList.Add(w);
        }

        return resultList;
    }
}
*/