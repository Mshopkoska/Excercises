/*using System;

public class CountIPAddresses
{
	public static void Main()
	{
		string start = "10.0.0.0";
		string end = "10.0.0.50";

		int[] a = start.Split('.').Select(int.Parse).ToArray();
		int[] b = end.Split('.').Select(int.Parse).ToArray();

		int x = (((a[0] - b[0]) * 256 + a[1] - b[1]) * 256 + a[2] - b[2]) * 256 + a[3] - b[3];
		return;
	}
}
*/