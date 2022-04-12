using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumSquaredDivisors
{
    public static IEnumerable<int> GetDivisors(int n)
    {
        return from a in Enumerable.Range(2, n / 2)
               where n % a == 0
               select a;
    }
    public static Boolean isPerfectSquare(int n)
    {
        double result = Math.Sqrt(n);
        bool isSquare = result % 1 == 0;
        return isSquare;
    }
    // calculates the sum of squared divisors, and if it is a square, it returns the value, otherwise 0
    public static int getSum(List<int> divisorsList)
    {
        List<int> squaredDivisors = divisorsList.ToArray().Select(x => (Convert.ToInt32(x) * Convert.ToInt32(x))).ToList();
        int sum = Convert.ToInt32(squaredDivisors.Sum());
        if (isPerfectSquare(sum)) return sum;

        return 0;
    }

    public static string listSquared(long m, long n)
    {
        string[] pair = new string[2];
        StringBuilder st = new StringBuilder();

        for (int i = (int)m; i <= (int)n; i++)
        {
            List<int> divisorsList = GetDivisors(i).ToList();

            if (!divisorsList.Contains(1)) divisorsList.Add(1);
            if (!divisorsList.Contains(i)) divisorsList.Add(i);

            int sum = getSum(divisorsList);
            if (sum != 0)
            {
                pair[0] = i.ToString();
                pair[1] = sum.ToString();
                st.Append('[');
                st.Append(String.Join(", ", pair));
                st.Append("], ");
            }
        }
        if (st.Length != 0) st.Length -= 2;

        return "[" + st.ToString() + "]";
    }
}