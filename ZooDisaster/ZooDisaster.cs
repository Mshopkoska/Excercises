using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Dinglemouse
{
    public static Boolean canEatLeft(List<String> zooList, int i, List<string> zooRules)
    {
        string thing = zooList[i];
        if (i != 0)
        {
            string leftThing = zooList[i - 1];
            string situation = thing + " " + leftThing;
            if (zooRules.Contains(situation)) return true;
            else return false;
        }
        else return false;
    }

    public static Boolean canEatRight(List<String> zooList, int i, List<string> zooRules)
    {
        string thing = zooList[i];
        if (i != zooList.Count() - 1)
        {
            string rightThing = zooList[i + 1];
            string situation = thing + " " + rightThing;
            if (zooRules.Contains(situation)) return true;
            else return false;
        }
        else return false;
    }

    public static string eatLeft(int i, List<String> zooList)
    {
        string thing = zooList[i];
        string leftThing = zooList[i - 1];
        string report = thing + " eats " + leftThing;

        zooList.RemoveAt(i - 1);

        return report;
    }

    public static string eatRight(int i, List<String> zooList)
    {
        string thing = zooList[i];
        string rightThing = zooList[i + 1];
        string report = thing + " eats " + rightThing;

        zooList.RemoveAt(i + 1);

        return report;
    }

    public static string[] result(string zoo, List<String> eatingReport, List<String> zooList)
    {
        string[] result = new string[1 + 1 + eatingReport.Count()];
        result[0] = zoo;

        int i = 1;
        foreach (string s in eatingReport)
        {
            result[i++] = s;
        }

        StringBuilder st = new StringBuilder();
        foreach (string s in zooList)
        {
            st.Append(s + ",");
        }
        st.Remove(st.Length - 1, 1);
        result[i] = st.ToString();

        return result;
    }

    public static string[] WhoEatsWho(String zoo)
    {
        List<string> zooRules = new List<string>();
        zooRules.Add("antelope grass");
        zooRules.Add("big-fish little-fish");
        zooRules.Add("bug leaves");
        zooRules.Add("bear big-fish");
        zooRules.Add("bear bug");
        zooRules.Add("bear chicken");
        zooRules.Add("bear cow");
        zooRules.Add("bear leaves");
        zooRules.Add("bear sheep");
        zooRules.Add("chicken bug");
        zooRules.Add("cow grass");
        zooRules.Add("fox chicken");
        zooRules.Add("fox sheep");
        zooRules.Add("giraffe leaves");
        zooRules.Add("lion antelope");
        zooRules.Add("lion cow");
        zooRules.Add("panda leaves");
        zooRules.Add("sheep grass");



        string[] splitted = zoo.Split(",");
        List<String> zooList = new List<String>(splitted);

        List<String> eatingReport = new List<string>();

        int i = 0;
        while (i < zooList.Count)
        {
            string thing = zooList[i];

            Boolean ateLeft = false;
            Boolean ateRight = false;

            if (canEatLeft(zooList, i, zooRules))
            {
                string report = eatLeft(i, zooList);
                eatingReport.Add(report);
                ateLeft = true;
                //koga trgame vo listata levo indeksite se pomestuvaat
                //pa vrati se eden element nazad
                i--;
            }


            else if (canEatRight(zooList, i, zooRules))
            {
                string report = eatRight(i, zooList);
                eatingReport.Add(report);
                ateRight = true;

            }

            Boolean reseted = false;
            if (!(ateLeft == false && ateRight == false)) //znachi ako izelo bilo shto resetiraj
            {
                i = 0;
                reseted = true;
            }

            if (i == 0 && zooList.Count() == 1) break;
            if (reseted == false) i++;
        }
        if (zoo.Length != 0) return result(zoo, eatingReport, zooList);
        else
        {
            string[] result = new string[1];
            result[0] = string.Empty;
            return result;
        }

    }
}