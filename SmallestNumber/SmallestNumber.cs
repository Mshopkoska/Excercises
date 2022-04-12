// See https://aka.ms/new-console-template for more information
/*
public class ToSmallest
{
    public static void Main()
    {
        long n = 1084300149737110440;

        char[] digits = n.ToString().ToCharArray();
        int[] d = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));
        int smallestDigit = d.Min();
        int index = Array.IndexOf(d, smallestDigit);

        //int i = 0;
        LinkedList<int> temp = new LinkedList<int>(d);
        long[] result = new long[3];


        //Case1: 0 na vtora pozicija
        //Case2: 0 na pozicija pogolema od 2
        //Case 3: broj bez 0
            //Case 3.1: ako najmalata cifra e na pochetok na broj, najdi na vtorata pomala cifra 
            //Case 3.2 ako ne e na prva pozicija, premesti najnormalno

        //Case1: 0 na vtora pozicija
        if(smallestDigit == 0 && index == 1)
        {
            //togas sakame  od 20124 da dobieme 2124 so toa sto ja pomestuvame dvojkata aka brisheme 0 samo
            index = Array.LastIndexOf(d, smallestDigit);

            List<int> temp2 = new List<int>(temp);
            temp2.RemoveAt(1);

            string num = string.Join("", temp2);
            long number = long.Parse(num);

            result[0] = number;
            result[1] = 0;
            result[2] = (long)index;
        }
        //Case2: 0 na pozicija pogolema od 2
        else if (smallestDigit == 0 && index >= 1) //230459 0lata ide na pochetok od 2index kon 0ti 
        {
            index = Array.LastIndexOf(d,0); //poslednata nula da ja najdeme ako ima povekje

            List<int> temp2 = new List<int>(temp);
            temp2.RemoveAt(index);

            string num = string.Join("", temp2);
            long number = long.Parse(num);


            result[0] = number;
            result[1] = (long)index;
            result[2] = 0;
        }
        //Case 3: broj bez 0
        else
        {
            index = Array.LastIndexOf(d, smallestDigit);

            //Case 3.1: ako najmalata cifra e na pochetok na broj, najdi na vtorata pomala cifra 
            if (index == 0) //ako ima smao edna najmala cifra i taa e na pochetok na brojot, najdi ja slednata pomala
            {
                int[] cutted = d.Skip(1).ToArray();
                smallestDigit = cutted.Min();
                index = Array.LastIndexOf(d, smallestDigit);

                List<int> temp2 = new List<int>(d);
                temp2.RemoveAt(index);
                temp2.Insert(1, smallestDigit); // dodadi na prva aka vtora pozicija

                string num = string.Join("", temp2);
                long number = long.Parse(num);

                result[0] = number;
                result[1] = (long)index;
                result[2] = 1;

            }
            //Case 3.2 ako ne e na prva pozicija, premesti najnormalno
            else
            {
                index = Array.IndexOf(d, smallestDigit);
                List<int> temp2 = new List<int>(temp);
                temp2.RemoveAt(index);
                temp2.Insert(0, smallestDigit); // dodadi na prva aka vtora pozicija

                string num = string.Join("", temp2);
                long number = long.Parse(num);

                result[0] = number;
                result[1] = (long)index;
                result[2] = 0;
            }
        }
        Console.WriteLine("[" + result[0].ToString() + " " + result[1].ToString() + " " + result[2].ToString()+ "]");

    }
}*/