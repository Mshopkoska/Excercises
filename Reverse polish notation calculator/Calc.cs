using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Excercises.Reverse_polish_notation_calculator
{
	public class Calc
	{
		public static double evaluate(string expr)
		{
            if (expr == "" || expr.Length==0 || expr==null) return 0d;
            Stack<string> stack = new Stack<string> ();
            string[] sArray = expr.Split(" ");
            for(int i = 0; i< sArray.Length; i++)
            {
                string ch = sArray[i];
                Regex rg1 = new Regex(@"\+");
                Regex rg2 = new Regex(@"\-");
                Regex rg3 = new Regex(@"\*");
                Regex rg4 = new Regex(@"\/");
                
                if (rg1.IsMatch(ch))
                {
                    string b = stack.Pop();
                    string a = stack.Pop();
                    int s = int.Parse(a) + int.Parse(b);
                    stack.Push(s.ToString());
                }else if (rg2.IsMatch(ch))
                {
                    string b = stack.Pop();
                    string a = stack.Pop();
                    int s = int.Parse(a) - int.Parse(b);
                    stack.Push(s.ToString());
                }
                else if (rg3.IsMatch(ch))
                {
                    string b = stack.Pop();
                    string a = stack.Pop();
                    int s = int.Parse(a) * int.Parse(b);
                    stack.Push(s.ToString());
                }
                else if (rg4.IsMatch(ch))
                {
                    string b = stack.Pop();
                    string a = stack.Pop();
                    int s = int.Parse(a) / int.Parse(b);
                    stack.Push(s.ToString());
                }
                else
                {
                    stack.Push(ch);
                }

            }
            return double.Parse(stack.Pop());
        }
    }
}
