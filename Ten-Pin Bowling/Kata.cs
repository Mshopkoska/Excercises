using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Ten_Pin_Bowling
{
    public static class Kata
    {
        public static int BowlingScore(string frames)
        {
            int score = 0;
            List<int> rolls = new List<int>();
            string[] f = frames.Split(" ");
            foreach (string frame in f)
            {
                char[] balls = frame.ToCharArray();
                foreach (char ball in balls)
                {
                    if (ball == 'X') rolls.Add(10);
                    else if (ball == '/') rolls.Add(10 - rolls[rolls.Count - 1]);
                    else rolls.Add(int.Parse(ball.ToString()));
                }
            }
            rolls.Add(0);
            rolls.Add(0);

            int fr = 0;
            for (int i = 0; i < 10; i++)
            {
                int point = rolls[fr];
                int nPoint = rolls[fr + 1];
                int nnPoint = rolls[fr + 2];
                if (point == 10)
                {
                    score += 10 + (nPoint + nnPoint);
                    fr++;
                }
                else if ((point + nPoint) == 10)
                {
                    score += 10 + (nnPoint);
                    fr += 2;
                }
                else
                {
                    score += point + nPoint;
                    fr += 2;
                }
            }
            return score;
        }

    }
}
