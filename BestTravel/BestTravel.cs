using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public static class SumOfK
{

    private static bool NextCombination(IList<int> num, int n, int k)
    {
        bool finished;

        var changed = finished = false;

        if (k <= 0) return false;

        for (var i = k - 1; !finished && !changed; i--)
        {
            if (num[i] < n - 1 - (k - 1) + i)
            {
                num[i]++;

                if (i < k - 1)
                    for (var j = i + 1; j < k; j++)
                        num[j] = num[j - 1] + 1;
                changed = true;
            }
            finished = i == 0;
        }

        return changed;
    }

    private static IEnumerable Combinations<T>(IEnumerable<T> elements, int k)
    {
        var elem = elements.ToArray();
        var size = elem.Length;

        if (k > size) yield break;

        var numbers = new int[k];

        for (var i = 0; i < k; i++)
            numbers[i] = i;

        do
        {
            yield return numbers.Select(n => elem[n]);
        } while (NextCombination(numbers, size, k));
    }

    public static List<List<int>> getCombinations(List<int> ls, int t)
    {
        string[] arr = ls.Select(i => i.ToString()).ToArray();

        List<List<int>> combinations = new List<List<int>>();
        int[] nums = new int[t];

        foreach (IEnumerable<string> i in Combinations(arr, t))
        {
            string[] r = i.ToArray();
            int[] rr = r.Select(s => int.Parse(s)).ToArray();
            combinations.Add(rr.ToList());
        }
        return combinations;
    }

    public static List<int> getSums(List<List<int>> combinations)
    {
        List<int> sums = new List<int>();
        foreach (List<int> list in combinations)
        {
            sums.Add(list.Sum());
        }
        return sums;
    }

    public static List<int> filteredSums(List<int> sums, int max)
    {

        for (int i = 0; i < sums.Count(); i++)
        {
            if (sums[i] > max)
                sums[i] = 0;
        }
        return sums;
    }

    public static int? chooseBestSum(int t, int k, List<int> ls)
    {
        List<List<int>> combinations = getCombinations(ls, k);
        List<int> sums = getSums(combinations);
        if (sums.Count == 0) return null;
        int max = filteredSums(sums, t).Max();
        if (max == 0) return null;
        return max;
    }
}