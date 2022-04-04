using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
/*
namespace Excercises
{
    internal class PhoneDirectory
    {
        public static void Main()
        {
            string input = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010!\n";
            string num = "48-421-674-8974";

            List<string> inputs = input.Split('\n').ToList(); //ovde ke se zacuva kako lista od inputite
            Hashtable phonebook = new Hashtable();

            foreach(string l in inputs) //zimam eden red ne splitnat
            {
                //vo tabelata key e brojot, value e string[] so format [adresa, ime i prezime]

                //Regex pattern = new Regex(@"/+(?<number>\d+) (?<address>\d+) <(?<name>\d+)>");
                /*Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6} ");
                Match match = pattern.Match(l);

                //prezemanje na brojot
                string number = (match.Groups["number"].Value);
                number = Regex.Replace(number, "[-]", string.Empty);

                //adresata i imeto
                string address = match.Groups["address"].Value;
                string name = match.Groups["name"].Value;

                //dodavame vo hashtable
                string[] details = { address, name };
                phonebook.Add(number,details);

                string proba = Regex.Replace(l, "[@,\\.\";'\\\\+/!]", string.Empty);
                string[] splitted = proba.Split(" ");

            }

            if (phonebook.ContainsKey(num)){
                String[] result = (string[])phonebook[num];

                StringBuilder st = new StringBuilder();
                st.Append("Phone => " + num + ", " + "Name => " + result[1] + ", " + "Address => " + result[0]);
                string re = st.ToString(); 
            }

        }
    }
}
 */         