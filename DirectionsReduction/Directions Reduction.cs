
public class DirectionsReduction
{
	public static void Main()
	{
		string[] arr = { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
		//string[] arr2 = { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" };
		List<string> list = new List<string>(arr);
		
		int i = 0;
        while (i<list.Count()-1)
        {
			if((list.ElementAt(i)=="NORTH" && list.ElementAt(i+1) == "SOUTH") || (list.ElementAt(i) == "SOUTH" && list.ElementAt(i+1) == "NORTH") 
				|| (list.ElementAt(i) == "EAST" && list.ElementAt(i+1) == "WEST") || (list.ElementAt(i) == "WEST" && list.ElementAt(i+1) == "EAST")) { 

				list.RemoveAt(i); //dvete gi brishe od nasoki
				list.RemoveAt(i);
				if(i!=0) i--;
			}
			else i++;
		}

		
}
}
