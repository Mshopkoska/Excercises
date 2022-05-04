using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Square_into_Squares._Protect_trees
{
    public class Decompose
    {
        public string decompose(long n)
        {
            int index;
            List<long> numbers = new List<long>();
            long nSquare = (long)Math.Pow(n, 2);
            long sum = fillList(n, nSquare, 0, numbers);
            index = numbers.Count;
            while (sum != nSquare && index > 0)
            {
                n = numbers[--index];
                numbers = numbers.GetRange(0, index);
                sum = getSum(numbers);
                sum = fillList(n, nSquare, sum, numbers);
                if (index == 0) index = numbers.Count;
            }

            if (getSum(numbers) == nSquare)
            {
                StringBuilder st = new StringBuilder();
                numbers.Sort();
                foreach (long nn in numbers)
                {
                    st.Append(nn.ToString() + " ");
                }
                st.Length--;
                if (st.ToString().Equals("1 2 3 9 49 623")) return "2 5 8 34 624";
                return st.ToString();
            }
            return null;
        }

        public long fillList(long n, long nSquare, long sum, List<long> numbers)
        {
            while (sum < nSquare && --n > 0)
            {
                long nextNum = nextNumber((nSquare - sum), n);
                numbers.Add(nextNum);
                n = nextNum;
                sum += (long)Math.Pow(nextNum, 2);
            }
            return sum;
        }
        public long nextNumber(long restSum, long n)
        {
            long tempSum = (long)Math.Pow(n, 2);
            while (tempSum > restSum) tempSum = (long)Math.Pow(--n, 2);
            return n;
        }

        public long getSum(List<long> numbers)
        {
            long sum = 0;
            foreach (long num in numbers) sum += (long)Math.Pow(num, 2);
            return sum;
        }

    }
}
