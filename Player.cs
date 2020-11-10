using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Player
    {
        private List<Indvscore> scoreList;

        public Player()
        {
            scoreList = new List<Indvscore>();
        }

        public int getSize()
        {
            return scoreList.Count;
        }

        public Indvscore getscore(int idx)
        {
            return scoreList[idx];
        }

        public void Addplayer(Indvscore p)
        {
            Boolean alreadyExist = false;

            for (int i = 0; i < scoreList.Count; i++)
            {
                if (scoreList[i].getName() == p.getName())
                {
                    scoreList[i].setScore(scoreList[i].getScore() + p.getScore());
                    alreadyExist = true;
                }
            }

            if (alreadyExist == false)
            {
                scoreList.Add(p);
            }
        }
    }
}
