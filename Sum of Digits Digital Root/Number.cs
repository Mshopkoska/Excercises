using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Sum_of_Digits_Digital_Root
{
    public class Number
    {
        public int DigitalRoot(long n)
        {
            // Your awesome code here!
            return (n != 0 && n % 9 == 0) ? 9 : (int)n % 9;
        }
    }
}
