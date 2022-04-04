using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

        //int[] arr = { 1, 2, 3, 6, 4, 1, 2, 3, 2, 1 };
        // int[] arr = { 1, 2, 2, 2, 1 };

        List<int> positions = new List<int>();
        List<int> peaks = new List<int>();
        Boolean platoFlag = false;
        int possiblePlatoIndex = 0;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            int current = arr[i];
            int prev = arr[i - 1];
            int next = arr[i + 1];

            if (platoFlag == true)
            {
                //sluchaj 1 2 2 1
                if (next < current)
                {
                    positions.Add(possiblePlatoIndex);
                    peaks.Add(current);
                    platoFlag = false;  //resetijraj flag
                }

                //sluchaj 1 2 2 3
                if (next > current)
                {
                    platoFlag = false;  //resetijraj flag
                    possiblePlatoIndex = 0;
                }

                //else sluchaj 1 2 2 2, prodolzi ponatamu
                if (next == current)
                {
                    platoFlag = true;  //produzhi ponatamu
                }
            }

            else if (prev < current && current > next) //we have a peak
            {
                positions.Add(i);
                peaks.Add(current);

            }
            else if (prev < current && next == current)
            {
                platoFlag = true;
                possiblePlatoIndex = i;
            }
        }

        dictionary.Add("pos", positions);
        dictionary.Add("peaks", peaks);
        return dictionary;
    }
}