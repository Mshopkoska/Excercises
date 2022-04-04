namespace myjinxin
{
    using System;

    public class Kata
    {
        public int BestMatch(int[] goals1, int[] goals2)
        {
            int[] minimalGol = new int[4] { (goals1[0] - goals2[0]), goals1[0], goals2[0], 0 }; //format [ golRazlika, goal1-AL, goal2-Zamalek, index]

            for (int i = 0; i < goals1.Length; i++)
            {
                int diff = goals1[i] - goals2[i];

                if (diff == minimalGol[0]) // ako imame ista gol razlika, sporedi gi stariot gol na Zamalek so noviot
                {
                    if (goals2[i] > minimalGol[2]) //ako noviot input e pogolem, updejtni celo, inaku ne updejtnuvaj
                    {
                        minimalGol[0] = diff;
                        minimalGol[1] = goals1[i];
                        minimalGol[2] = goals2[i];
                        minimalGol[3] = i;
                    }
                }

                if (diff < minimalGol[0]) //ako novata razlika e pomala od starata, updejtni
                {
                    minimalGol[0] = diff;
                    minimalGol[1] = goals1[i];
                    minimalGol[2] = goals2[i];
                    minimalGol[3] = i;
                }
            }

            int rezultat = minimalGol[3];
            return rezultat;


        }
    }
}