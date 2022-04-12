using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Merged_String_Checker
{
    internal class StringMerger
    {

        public static bool isMerge(string s, string part1, string part2)
        {
            if ((part1.Length == 0 || part1 == null || part1 == "") && (part2.Length == 0 || part2 == null || part2 == "")) return true;
            if (s.Length == 0 || s == null || s == "") return false;
            if ((part1.Length + part2.Length) != s.Length) return false;

            if (part1.Length == 0)
            {
                if (s.Equals(part2)) return true;
                else return false;
            }
            if (part2.Length == 0)
            {
                if (s.Equals(part1)) return true;
                else return false;
            }

            char[] first = part1.ToCharArray();
            char[] second = part2.ToCharArray();

            int j = 0, t = 0;
            Boolean firstFlag = false;
            Boolean secondFlag = false;
            for (int i = 0; i < s.Length; i++)
            {
                char charOfString = s[i];
                if (j < first.Length && t < second.Length && (i + 1) < s.Length)
                {
                    char charOfPart1 = first[j];
                    char charOfPart2 = second[t];

                    if (charOfPart1 == charOfPart2)
                    {
                        //proveri narednata bukva od kaj moze da se zeme
                        if((j+1)< first.Length && (t+1)< second.Length)
                        {
                            int counter1 = j + 1;
                            int counter2 = t + 1;
                            int counter3 = i + 1;

                            while (true)
                            {
                                char nextCharOfPart1 = first[counter1];
                                char nextCharOfPart2 = second[counter2];

                                if (nextCharOfPart1 == nextCharOfPart2)
                                {
                                    counter1++;
                                    counter2++;
                                    counter3++;
                                    firstFlag = true;
                                    secondFlag = true;
                                }
                                else if (nextCharOfPart1 == s[counter3])  // ako narednata bukva e od prviot string
                                {
                                    j++;
                                    firstFlag = true;
                                    break;
                                }
                                else //(nextCharOfPart2 == s[counter3])
                                {
                                    t++;
                                    secondFlag = true;
                                    break;
                                }

                                if (firstFlag == false && secondFlag == false) return false; // ako ja nema bukvata avtomatski false vrati
                                firstFlag = false;
                                secondFlag = false;
                            }
                        }

                    }
                    else
                    {
                        if (j < first.Length)
                        {
                            //char charOfPart1 = first[j];
                            if (charOfString == charOfPart1)
                            {
                                j++;
                                firstFlag = true;
                            }
                        }
                        if (t < second.Length)
                        {
                            //char charOfPart2 = second[t];
                            if (charOfString == charOfPart2)
                            {
                                t++;
                                secondFlag = true;
                            }
                        }
                        if (firstFlag == false && secondFlag == false) return false; // ako ja nema bukvata avtomatski false vrati
                        firstFlag = false;
                        secondFlag = false;
                    }
                }

                else if (j == first.Length && t < second.Length) //ako prviot zbor e zavrshen
                {
                    char charOfPart2 = second[t];
                    //prodolzi so vtoriot zbor
                    if (charOfString == charOfPart2) t++;
                    else return false; // ako ne e taa bukva 
                }
                else if (t == second.Length && j < first.Length)
                {
                    char charOfPart1 = first[j];
                    if (charOfString == charOfPart1) j++;
                    else return false; // ako ne e taa bukva 
                }


            }
            return true;

        }
        /*public static void Main(){

            string s = "Bananas from Bahamas";
            string part1 = "Bahas";
            string part2 = "Bananas from am";

            if(isMerge(s,part1,part2) == true)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");


        }*/
    }
}
