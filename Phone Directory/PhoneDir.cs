using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Excercises
{
    public class PhoneDir
    {
        public string name { get; set; }
        public string number { get; set; }
        public string address { get; set; }


        public static string getAddress(string s, string name, string number)
        {
            int indexOfName = s.IndexOf(name);
            string address = s.Remove(indexOfName, name.Length);

            int indexOfNumber = address.IndexOf(number);
            address = address.Remove(indexOfNumber, number.Length);

            //var st = "San Antonio TT-45120";
            var reg = new Regex(@"[^ .\-A-Z a-z 0-9 ]");
            var result = reg.Replace(address, " ");

            List<string> splitted = new List<String>(result.Split(" "));
            splitted.RemoveAll(x => x == "");
            //splitted.RemoveAll(x => x == " ");

            string res = string.Join(" ", splitted);

            return res;
        }


        public static string Phone(string strng, string num)
        {
            List<string> inputs = strng.Split('\n').ToList(); //ovde ke se zacuva kako lista od inputite
            Dictionary<string, List<PhoneDir>> phonebook = new Dictionary<string, List<PhoneDir>>();
            inputs.RemoveAt(inputs.Count - 1);
            foreach (string line in inputs)
            {
                //phone number
                Regex pattern = new Regex(@"(\d{1}-)?(\d{2}-)?\d{3}-\d{3}-\d{4}");
                Match number = pattern.Match(line);

                //name
                pattern = new Regex(@"<((.+)(\s+(.+))?)>");
                Match n = pattern.Match(line);
                string name = n.ToString().Substring(1, n.ToString().Length - 2);

                //address
                string address = getAddress(line, n.ToString(), number.ToString());

                PhoneDir contact = new PhoneDir();
                contact.number = number.ToString();
                contact.name = name;
                contact.address = address;

                if (phonebook.ContainsKey(number.ToString()))
                {
                    phonebook[number.ToString()].Add(contact);
                }
                else
                {
                    List<PhoneDir> list = new List<PhoneDir>();
                    list.Add(contact);
                    phonebook[number.ToString()] = list;
                }
            }

            if (phonebook.ContainsKey(num))
            {
                if (phonebook[num].Count > 1) return string.Format("Error => Too many people: {0}", num.ToString());
                else
                {
                    PhoneDir c = phonebook[num].First();

                    StringBuilder st = new StringBuilder();
                    st.Append("Phone => " + num + ", " + "Name => " + c.name + ", " + "Address => " + c.address);
                    string re = st.ToString();

                    return re;
                }
            }
            else
            {
                return string.Format("Error => Not found: {0}", num);
            }
        }
    }
}