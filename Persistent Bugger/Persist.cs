using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Persistent_Bugger
{
	public class Persist
	{
		public static int Persistence(long n)
		{
            long result = 0;
            long counter = 0;
            while (n > 9)
            {
                result = 1;
                while (n > 0)
                {
                    result *= n % 10;
                    n /= 10;
                }
                counter++;
                n = result;
            }
            return (int)counter;
        }
	}
}
