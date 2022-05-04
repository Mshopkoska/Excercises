using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Codewars_style_ranking_system
{
    public class User
    {
        public int rank = -8;
        public int progress = 0;

        public void incProgress(int aRank)
        {
            if (aRank < -8 || aRank > 8 || aRank == 0) throw new ArgumentException();
            if (this.rank < 0 && aRank > 0) aRank--;
            if (this.rank > 0 && aRank < 0) aRank++;
            if (this.rank == aRank) this.progress += 3;
            if (this.rank - 1 == aRank) this.progress += 1;
            if (this.rank - 2 >= aRank) this.progress += 0;
            if (this.rank < aRank)
            {
                int d = aRank - this.rank;
                this.progress += (10 * d * d);
            }
            while (this.progress >= 100 && this.rank < 8)
            {
                if (++this.rank == 0) this.rank++;
                this.progress -= 100;
            }
            if (this.rank == 8) this.progress = 0;
        }
    }
}
