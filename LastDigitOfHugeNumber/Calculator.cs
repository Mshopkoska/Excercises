using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.LastDigitOfHugeNumber
{
    internal class Calculator
    {
        public static int LastDigit(int[] array)
        {
            if (array.Count() == 0) return 1;


            int result, powN;
            List<int> list = new List<int>(array);

            int n1 = list[0]; list.RemoveAt(0);
            if (list.Count() == 0) return n1 % 10;
            int n2 = list[0]; list.RemoveAt(0);

            // array size is 2
            if (list.Count() == 0)
            {
                if (n2 == 0) return 1;
                if (n1 == 0) return 0;
                if (n1 == 1) return 1;
                if (n2 == 1) return n1 % 10;

                powN = n2 % 4;
            }
            else
            {
                int n3 = list[0]; list.RemoveAt(0);

                // array size is 3
                if (list.Count() == 0)
                {
                    if (n3 == 0) n2 = 1;
                    if (n2 == 0) n1 = 1;
                    if (n1 == 0) return 0;
                    if (n2 == 1) return n1 % 10;
                    if (n1 == 1) return 1;

                    if (n3 == 0) return n1 % 10;

                    if (n3 == 1)
                    {
                        powN = n2 % 4;
                    }
                    else if (n3 % 2 == 1)
                    {
                        if (n2 % 2 == 0) powN = 0;
                        else powN = n2 % 4;
                    }
                    else
                    {
                        if (n2 % 2 == 0) powN = 0;
                        else powN = 1;
                    }
                }
                else// array size is over 4
                {
                    int n4 = list[0]; list.RemoveAt(0);

                    // calculate elements after 4th
                    if (!(list.Count() == 0))
                    {
                        int back = list[list.Count() - 1]; list.RemoveAt(list.Count() - 1);

                        while (!(list.Count() == 0))
                        {
                            int down = list[list.Count() - 1]; list.RemoveAt(list.Count() - 1);
                            if (back == 0) down = 1;
                            back = down;
                        }

                        if (back == 0) n4 = 1;
                    }

                    if (n4 == 0) n3 = 1;
                    if (n3 == 0) n2 = 1;
                    if (n2 == 0) n1 = 1;

                    if (n1 == 0) return 0;
                    if (n2 == 1) return n1 % 10;
                    if (n1 == 1) return 1;

                    if (n4 == 0)
                    {
                        powN = n2 % 4;
                    }
                    else
                    {
                        if (n3 == 0)
                        {
                            return n1 % 10;
                        }

                        if (n3 == 1)
                        {
                            powN = n2 % 4;
                        }
                        else if (n3 % 2 == 1)
                        {
                            if (n2 % 2 == 0) powN = 0;
                            else powN = n2 % 4;
                        }
                        else
                        {
                            if (n2 % 2 == 0) powN = 0;
                            else powN = 1;
                        }
                    }
                }
            }

            // calculate last digit
            if (powN == 0) powN = 4;
            result = 1;
            n1 = n1 % 10;
            for (int i = 0; i < powN; ++i)
            {
                result = (result * n1) % 10;
            }

            return result;
        }
    }
}
