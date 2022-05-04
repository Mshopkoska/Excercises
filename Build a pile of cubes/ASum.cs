using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Build_a_pile_of_cubes
{
	public class ASum
	{
		public static long findNb(long m)
		{
			int n = 0;
			do
			{
				m = m - (long)Math.Pow(n++ + 1d, 3d);
			} while (m > 0);
			return (m == 0) ? n : -1;
		}

	}

}
