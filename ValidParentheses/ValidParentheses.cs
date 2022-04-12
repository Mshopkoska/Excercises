using System;

/*
public class ValidParentheses
{
	public static void Main()
	{
		String input = "hi(hi) hi(hi))(";
		string r = "";
		if (input.Length == 0) r = "FALSE";//return false;
		if (!(input.Contains('(') || input.Contains(')'))) r = "FALSE";
		

		//string input = "()";
		char[] arr = input.ToCharArray();
		
		int result = 0;

		for (int i = 0; i < arr.Count(); i++)
		{
			char c = arr[i];
			if (c == '(') result += 1;
			else if (c == ')') result -= 1;
			//ako e bilo sto drugo, ne pravi nisto

		}

		 if(result == 0) r = "TRUE";
		 else r = "FALSE";

		 Console.WriteLine(r);
	}
}*/