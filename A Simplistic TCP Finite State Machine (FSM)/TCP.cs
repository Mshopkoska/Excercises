using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.A_Simplistic_TCP_Finite_State_Machine__FSM_
{
    public class TCP
    {
        public static string TraverseStates(string[] events)
        {
            var state = "CLOSED"; // initial state, always
                                  // Your code here!

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(string.Join(", ",new string[] { "CLOSED", "APP_PASSIVE_OPEN" }), "LISTEN");
            dictionary.Add(string.Join(", ", new string[] { "CLOSED", "APP_ACTIVE_OPEN" }), "SYN_SENT");
            dictionary.Add(string.Join(", ", new string[] { "LISTEN", "RCV_SYN" }), "SYN_RCVD");
            dictionary.Add(string.Join(", ", new string[] { "LISTEN", "APP_SEND" }), "SYN_SENT");
            dictionary.Add(string.Join(", ", new string[] { "LISTEN", "APP_CLOSE" }), "CLOSED");
            dictionary.Add(string.Join(", ", new string[] { "SYN_RCVD", "APP_CLOSE" }), "FIN_WAIT_1");
            dictionary.Add(string.Join(", ", new string[] { "SYN_RCVD", "RCV_ACK" }), "ESTABLISHED");
            dictionary.Add(string.Join(", ", new string[] { "SYN_SENT", "RCV_SYN" }), "SYN_RCVD");
            dictionary.Add(string.Join(", ", new string[] { "SYN_SENT", "RCV_SYN_ACK" }), "ESTABLISHED");
            dictionary.Add(string.Join(", ", new string[] { "SYN_SENT", "APP_CLOSE" }), "CLOSED");
            dictionary.Add(string.Join(", ", new string[] { "ESTABLISHED", "APP_CLOSE" }), "FIN_WAIT_1");
            dictionary.Add(string.Join(", ", new string[] { "ESTABLISHED", "RCV_FIN" }), "CLOSE_WAIT");
            dictionary.Add(string.Join(", ", new string[] { "FIN_WAIT_1", "RCV_FIN" }), "CLOSING");
            dictionary.Add(string.Join(", ", new string[] { "FIN_WAIT_1", "RCV_FIN_ACK" }), "TIME_WAIT");
            dictionary.Add(string.Join(", ", new string[] { "FIN_WAIT_1", "RCV_ACK" }), "FIN_WAIT_2");
            dictionary.Add(string.Join(", ", new string[] { "CLOSING", "RCV_ACK" }), "TIME_WAIT");
            dictionary.Add(string.Join(", ", new string[] { "FIN_WAIT_2", "RCV_FIN" }), "TIME_WAIT");
            dictionary.Add(string.Join(", ", new string[] { "TIME_WAIT", "APP_TIMEOUT" }), "CLOSED");
            dictionary.Add(string.Join(", ", new string[] { "CLOSE_WAIT", "APP_CLOSE" }), "LAST_ACK");
            dictionary.Add(string.Join(", ", new string[] { "LAST_ACK", "RCV_ACK" }), "CLOSED");

            foreach (String ev in events){
                string[] s = new string[] { state, ev };
                if (dictionary.ContainsKey(string.Join(", ",s)))
                {
                    string dd = (string.Join(", ", new string[] { state, ev }));
                    state = dictionary[dd];
                }else
                {
                    return "ERROR";
                }
            }

            return state;
        }

    }
}
