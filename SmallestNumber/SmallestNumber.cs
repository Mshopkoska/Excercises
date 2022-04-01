// See https://aka.ms/new-console-template for more information
/*public class ToSmallest
{
    public static void Main()
    {
        //long n = 261235;
        long n = 261235;
        //finding the smallest Digit
        char[] digits = n.ToString().ToCharArray();
        int[] d = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));
        int smallest = d.Min();
        int index = Array.IndexOf(d, smallest);

         int i = 0;  //[2,6,1,2,3,5] -> [1,2,6,1,2,3,5] -> [1,2,6,2,3,5]
         LinkedList<int> temp = new LinkedList<int>(d);
         long[] result = new long[3];
             if ( smallest == 0 && index == 1)
            {
            //togas sakame  od 20124 da dobieme 2124 so toa sto ja pomestuvame dvojkata aka brisheme 0 samo
                index = Array.LastIndexOf(d, smallest);

                 List<int> temp2 = new List<int>(temp);
                 temp2.RemoveAt(1);

                string num = string.Join("", temp2);
                long number = long.Parse(num);

                result[0] = number;
                result[1] = (long)i;
                result[2] = (long)index;
        }
         
            if (index != i) //ako treba da se pomesi nenulti broj
            {
                index = Array.LastIndexOf(d, smallest);
                var position = temp.Find(d[i]); //da ja najde pozicijata pred koja sakame da dodademe
                temp.AddBefore(position, d[index]); //ja dodava najmalata vrednost pred pozicijata


                int removeIndex = index + 1;

                List<int> temp2 = new List<int>(temp);
                temp2.RemoveAt(removeIndex);

                string num = string.Join("", temp2);
                long number = long.Parse(num);

                 result[0] = number;
                 result[1] = (long)index;
                 result[2] = (long)i;
        }   
            else //ako treba da se pomesti nula koja e na pogolema pozicija od 2 
            {
                List<int> temp2 = new List<int>(temp);
                temp2.RemoveAt(index);

                string num = string.Join("", temp2);
                long number = long.Parse(num);


                result[0] = number;
                result[1] = (long)index;
                result[2] = (long)i;

        }

        return result;


    }
}*/