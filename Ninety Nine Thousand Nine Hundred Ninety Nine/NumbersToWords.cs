using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine
{
    internal class NumbersToWords
    {
        class Kata
        {
            public static string NumberToEnglish(int number)
            {
                //Do Some Magic
                if (number >= 0 && number <= 99999)
                {
                    if (number == 0)
                        return "zero";
                    if (number == 100)
                        return "one hundred";

                    string words = "";

                    if ((number / 1000000) > 0)
                    {
                        words += NumberToEnglish(number / 1000000) + " million ";
                        number %= 1000000;
                    }

                    if ((number / 1000) > 0)
                    {
                        words += NumberToEnglish(number / 1000) + " thousand ";
                        number %= 1000;
                    }

                    if ((number / 100) > 0)
                    {
                        words += NumberToEnglish(number / 100) + " hundred ";
                        number %= 100;
                    }

                    if (number > 0)
                    {
                        /*if (words != "")
                            words += "and ";*/

                        var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                        if (number < 20)
                            words += unitsMap[number];
                        else
                        {
                            words += tensMap[number / 10];
                            if ((number % 10) > 0)
                                words += " " + unitsMap[number % 10];
                        }
                    }
                    if (words[words.Length - 1] == ' ') words = words.Substring(0, words.Length - 1);
                    return words;
                }
                return "";
            }
        }
    }
}
