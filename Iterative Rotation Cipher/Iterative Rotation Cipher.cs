using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercises.Iterative_Rotation_Cipher
{

    public class IterativeRotationCipher
    {
        public static List<int> Spaces(string line)
        {
            List<int> spaces = new List<int>();
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == ' ')
                {
                    spaces.Add(i);
                }
            }
            return spaces;
        }

        public static string putSpacesBack(List<int> spacesIndexes, string message)
        {
            string result = message;

            int counter = 0;
            foreach (int index in spacesIndexes)
            {
                result = result.Insert(index + counter, " ");
            }

            return result;
        }

        public static string shiftByNRight(string word, int n)
        {
            char[] result = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                int newIndex = i;
                int counter = 0;  //kolku pati shiftnal
                while (counter < n)
                {
                    while (newIndex < word.Length && counter < n)
                    {
                        counter++;
                        newIndex++;
                    }
                    if (counter < n) newIndex = 0;
                }

                if (newIndex > word.Length - 1)
                {
                    newIndex = (newIndex) % word.Length;

                    result[newIndex] = word[i];
                }
                else
                {
                    result[newIndex] = word[i];
                }

            }
            return string.Join("", result);

        }
        public static string shiftWithSpaces(string message, int n, string direction)
        {
            string[] splitted = message.Split(' ');
            string[] result = new string[splitted.Count()];

            int i = 0;
            foreach (string s in splitted)
            {
                if (direction.Equals("left"))
                {
                    result[i++] = shiftByNLeft(s, n);
                }
                else result[i++] = shiftByNRight(s, n);
            }
            return String.Join(" ", result);
        }

        public static string Encode(int n, string s)
        {
            // your code goes here. you can do it!
            Boolean flag = false;
            if (s.Contains("\n"))
            {
                s = s.Replace("\n", "љ");
                flag = true;
            }

            //Step1: save spaces and then remove them

            List<int> spaces = Spaces(s);
            string removedSpaces = String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));

            //Step2: shift the order of string characters to the right by 10
            string shifted = shiftByNRight(removedSpaces, n);

            //step 3: put back the spaces
            string withSpaces = putSpacesBack(spaces, shifted);

            //step4: shift the order of characters for each space-separated substring to the right by 10
            string shiftedWords = shiftWithSpaces(withSpaces, n, "right");



            for (int i = 0; i < n - 1; i++)
            {
                //Step1: save spaces and then remove them
                spaces = Spaces(shiftedWords);
                removedSpaces = String.Concat(shiftedWords.Where(c => !Char.IsWhiteSpace(c)));


                //Step2: shift the order of string characters to the right by 10
                shifted = shiftByNRight(removedSpaces, n);

                //step 3: put back the spaces
                withSpaces = putSpacesBack(spaces, shifted);

                //step4: shift the order of characters for each space-separated substring to the right by 10
                shiftedWords = shiftWithSpaces(withSpaces, n, "right");

                spaces.Clear();
                shifted = "";
                withSpaces = "";

            }
            if (flag)
            {
                shiftedWords = shiftedWords.Replace("љ", "\n");
            }
            return n + " " + shiftedWords;

        }



        public static string shiftByNLeft(string word, int n)
        {

            char[] result = new char[word.Length];
            for (int i = word.Length - 1; i >= 0; i--)
            {
                int newIndex = i;
                int counter = 0;  //kolku pati shiftnal
                while (counter < n)
                {
                    while (newIndex >= 0 && counter < n)
                    {
                        counter++;
                        newIndex--;
                    }
                    if (counter < n) newIndex = word.Length - 1;
                }

                if (newIndex < 0)
                {
                    newIndex = (newIndex) + word.Length;

                    result[newIndex] = word[i];
                }
                else
                {
                    result[newIndex] = word[i];
                }

                result[newIndex] = word[i];

            }
            return string.Join("", result);
        }



        public static string Decode(string s)
        {
            Boolean flag = false;
            if (s.Contains("\n"))
            {
                s = s.Replace("\n", "љ");
                flag = true;
            }

            //get n from string
            string[] r = s.Split(" ");
            int n = int.Parse(r[0]); //ova e n 

            string message = string.Join(" ", r, 1, r.Length - 1); //samo stringot bez n mi treba

            //Reversed steps
            //step1: shift the order of characters for each space-separated substring to the left by n
            string shiftedWords = shiftWithSpaces(message, n, "left");

            //step2: remove spaces
            List<int> spaces = Spaces(shiftedWords);
            string removedSpaces = String.Concat(shiftedWords.Where(c => !Char.IsWhiteSpace(c)));

            //step 3: shift the whole string to the left by n
            string shifted = shiftByNLeft(removedSpaces, n);

            //step 4: put back spaces
            string withSpaces = putSpacesBack(spaces, shifted);


            for (int i = 0; i < n - 1; i++)
            {
                //Reversed steps
                //step1: shift the order of characters for each space-separated substring to the left by n
                shiftedWords = shiftWithSpaces(withSpaces, n, "left");

                //step2: remove spaces
                spaces = Spaces(shiftedWords);
                removedSpaces = String.Concat(shiftedWords.Where(c => !Char.IsWhiteSpace(c)));

                //step 3: shift the whole string to the left by n
                shifted = shiftByNLeft(removedSpaces, n);

                //step 4: put back spaces
                withSpaces = putSpacesBack(spaces, shifted);

                spaces.Clear();
                shifted = "";
                shiftedWords = "";

            }

            if (flag)
            {
                withSpaces = withSpaces.Replace("љ", "\n");
            }

            return withSpaces;
        }
    }
}


