using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;

public class TopWords
{
    public static List<string> Top3(string s)
    {
        var reg = new Regex(@"[^ ' A-Z a-z]");
        var result = reg.Replace(s, " ");

        var rx = new Regex(@"\s+", RegexOptions.Compiled);
        string[] splitted = rx.Split(result);

        Hashtable ht = new Hashtable();
        foreach (string str in splitted)
        {
            if (!ht.ContainsKey(str.ToLower()))
            {
                ht[str.ToLower()] = 1;
            }
            else
            {
                int frequency = (int)ht[str.ToLower()];
                ht[str.ToLower()] = frequency + 1;
            }
        }

        //<string,int>
        string[] arrKey = new string[ht.Count];
        int[] arrValue = new int[ht.Count];

        ht.Keys.CopyTo(arrKey, 0);
        ht.Values.CopyTo(arrValue, 0);

        Array.Sort(arrValue, arrKey);
        Array.Reverse(arrKey);
        string[] arrKey2 = arrKey;
        List<string> re = new List<String>(arrKey2);
        re.Remove("");
        re.Remove("\'");
        re.Remove("\'''");

        int i = 0;
        List<string> r = new List<String>();
        if (r.Contains("'''")) r.Remove("'''");
        while (i < 3 && i < re.Count)
        {
            r.Add(re[i++]);
        }
        return r;
    }
}