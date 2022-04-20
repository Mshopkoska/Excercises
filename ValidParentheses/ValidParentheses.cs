using System;


public class ValidParentheses
{

	public static bool ValidParenthesesw(string input)
	{
		/*if (input.Length == 0 || input == null || input == "") return false;
		if (!(input.Contains('(') || input.Contains(')'))) return false;

		char[] arr = input.ToCharArray();
		//if(arr[0]== ')') return false;

		int result = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			char c = arr[i];
			if (c == '(') result += 1;
			else if (c == ')') result -= 1;
		}

		if (result == 0) return true;
		else return false;*/

		Stack<char> stack = new Stack<char> ();
		foreach(char s in input)
        {

			if (s == '(') stack.Push(s);
			else if (s == ')')
            {
				if (stack.Count > 0) stack.Pop();
				else return false;
            }
		}
		if(stack.Count == 0) return true;
		else return false;	
	
	}
}