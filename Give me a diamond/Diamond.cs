using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Give_me_a_diamond
{
	public class Diamond
	{
		public static string print(int n)
		{
            if ((n % 2) == 0 || n <= 0) return null;
            StringBuilder diamond = new StringBuilder();
            for (int i = 1; i < n; i += 2)
            {
                for (int j = 0; j < (n - i) / 2; j++) diamond.Append(" ");
                for (int k = 0; k < i; k++) diamond.Append("*");
                diamond.Append("\n");
            }
            for (int i = n; i > 0; i -= 2)
            {
                for (int j = 0; j < (n - i) / 2; j++) diamond.Append(" ");
                for (int k = 0; k < i; k++) diamond.Append("*");
                diamond.Append("\n");
            }
            return diamond.ToString();
        }
	}
}
