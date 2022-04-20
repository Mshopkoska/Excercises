using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class MatchSubst
{
    public string programTitle { get; set; }
    public string author { get; set; }
    public string phone { get; set; }
    public string date { get; set; }
    public string version { get; set; }



    public static string Change(string s, string prog, string version)
    {
        string[] splitted = s.Split("\n");
        //0 program title
        //1 author
        //...

        MatchSubst matchSubst = new MatchSubst();

        matchSubst.programTitle = prog;
        matchSubst.author = "g964";

        //check phone
        string phone = splitted[3].Substring(7);
        Regex pattern = new Regex(@"\+1-\d{3}-\d{3}-\d{4}");
        if (!pattern.IsMatch(phone))
        {
            return "ERROR: VERSION or PHONE";
        }
        matchSubst.phone = "+1-503-555-0090";

        //date
        matchSubst.date = "2019-01-01";

        //check version
        string Version = splitted[5].Substring(9);
        pattern = new Regex(@"(\d{1}\.\d{1})|(\d{1}\.\d{2})|(\d{2}\.\d{2})|(\d{2}\.\d{1})");
        int count = Version.Split('.').Length - 1;
        if (!pattern.IsMatch(Version) || count > 1 || (!Version.Contains(".")))
        {
            return "ERROR: VERSION or PHONE";
        }
        else
        {
            if (Version != "2.0")
            {
                matchSubst.version = version;
            }
            else matchSubst.version = Version;
        }

        StringBuilder st = new StringBuilder();
        st.Append("Program: " + matchSubst.programTitle + " ");
        st.Append("Author: " + matchSubst.author + " ");
        st.Append("Phone: " + matchSubst.phone + " ");
        st.Append("Date: " + matchSubst.date + " ");
        st.Append("Version: " + matchSubst.version);

        return st.ToString();
    }
}

