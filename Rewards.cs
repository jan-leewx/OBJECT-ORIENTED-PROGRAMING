using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Snake
{
    class Rewards
    {
        List<Position> appleList;
        Board mainBoard;
        List<Position> enemylist;
        SoundPlayer eatpoptart;
        

        public Rewards(int size, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            appleList = new List<Position>();
            for (int i=0;i< size;i++)
            {
                int rowNo, colNo;

                //Generate an apple at random position but not duplicated
                do
                {
                    //Generate a random number between 1 and MaxRowNo
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo()+1);

                    //Generate a random number between 1 and MaxColNo
                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo()+1);

                } while (isDuplicate(rowNo, colNo) == true);

                appleList.Add(new Position(rowNo, colNo));
            }
            this.mainBoard = mainBoard;
            enemylist = new List<Position>();
            for (int i = 0; i < size; i++)
            {
                int rowNo, colNo;

                do
                {
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo() + 1);

                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo() + 1);

                } while (isDuplicate(rowNo, colNo) == true);

                enemylist.Add(new Position(rowNo, colNo));

            }

        }

        private Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< appleList.Count;i++)
            {
                if (appleList[i].getRowNo() == row && appleList[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        private Boolean isDuplicateenemy(int row, int col)
        {
            Boolean result = false;

            for (int i = 0; i < enemylist.Count; i++)
            {
                if (enemylist[i].getRowNo() == row && enemylist[i].getColNo() == col)
                    result = true;
            }
            return result;
        }
        public void draw()
        {
            for (int i = 0; i < appleList.Count; i++)
            {
                mainBoard.draw(appleList[i], Properties.Resources.Png);
            }     
        }
        public void drawenemy()
        {
            for (int i = 0; i < enemylist.Count; i++)
            {
                mainBoard.drawenemy(enemylist[i], Properties.Resources.tac_nayn);
            }
        }
        public Boolean checkIFSnakeHeadEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < appleList.Count; i++)
            {
                if (snakeHead.getRowNo() == appleList[i].getRowNo() && snakeHead.getColNo() == appleList[i].getColNo())
                    result = true;
            }
            return result;
        }
        public Boolean checkIFSnakeEatenemy(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < enemylist.Count; i++)
            {
                if (snakeHead.getRowNo() == enemylist[i].getRowNo() && snakeHead.getColNo() == enemylist[i].getColNo())
                    result = true;
            }
            return result;
        }
        public Boolean checkIFSnakeEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < appleList.Count; i++)
            {
                if (snakeHead.getRowNo() == appleList[i].getRowNo() && snakeHead.getColNo() == appleList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public int eatAppleAtPostion(Position p)
        {
            for(int i=0; i<appleList.Count; i++)
            {
                if(p.getRowNo()==appleList[i].getRowNo()&&p.getColNo()==appleList[i].getColNo())
                {
                    appleList.RemoveAt(i);
                    eatpoptart = new SoundPlayer(Properties.Resources.Anime_wow___sound_effect);
                    eatpoptart.LoadAsync();
                    eatpoptart.Play();
                }
            }


            return 50;  //50 points per apple
        }
        public int eatPoopAtPosition(Position a)
        {
            for (int i = 0; i < enemylist.Count; i++)
            {
                if (a.getRowNo() == enemylist[i].getRowNo() && a.getColNo()
                    == enemylist[i].getColNo())
                {
                    enemylist.RemoveAt(i);
                }
            }

            return 100;
        }
        public Boolean noMoreApples()
        {
            if (appleList.Count > 0)
                return false;
            else
                return true;
        }
        public Boolean noMoreenemy()
        {
            if (enemylist.Count > 0)
                return false;
            else
                return true;
        }
    }
}
