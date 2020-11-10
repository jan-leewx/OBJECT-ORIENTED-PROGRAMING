using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Indvscore
    {
        private string name;
        private int score;

        public Indvscore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public string getName()
        {
            return name;
        }

        public int getScore()
        {
            return score;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setScore(int score)
        {
            this.score = score;
        }
    }
}
