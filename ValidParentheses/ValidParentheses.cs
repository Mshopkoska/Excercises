/*using System;

public class ValidParentheses
{
	public static void Main()
	{
		string result = "";
		string input = "(()(()";
		char[] arr= input.ToCharArray();

		Stack<char> st = new Stack<char>();
		if (arr[0] == ')') result= "FALSE";

		foreach(char c in arr)
        {
			if (c == '(') st.Push(c);
			else if (c == ')' && st.Count() != 0) st.Pop();
			else
			{
				result = "false";
				break;
			}
		}
		if (st.Count() == 0) { result = "true"; }
		else result = "false";
	}
}*/
