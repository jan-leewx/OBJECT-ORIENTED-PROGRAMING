using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        Board mainBoard;
        List<Position> body;

        public Snake(Board mainBoard)
        {
            this.mainBoard = mainBoard;

            body = new List<Position>();

              body.Add(new Position(0, 0)); 

        }

        public void move(string direction)
        {
            Position currentHeadPosition = body[0];
            Position newHeadPosition = null;

            switch (direction)
            {
                case "UP":
                    if (currentHeadPosition.getRowNo() > mainBoard.getMinRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo()-1, currentHeadPosition.getColNo());
                    }
                    break;
                case "DOWN":
                    if (currentHeadPosition.getRowNo() < mainBoard.getMaxRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() + 1, currentHeadPosition.getColNo());
                    }
                    break;
                case "LEFT":
                    if (currentHeadPosition.getColNo() > mainBoard.getMinColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), currentHeadPosition.getColNo()-1);
                    }
                    break;
                case "RIGHT":
                    if (currentHeadPosition.getColNo() < mainBoard.getMaxColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), currentHeadPosition.getColNo()+1);
                    }
                    break;
                case "UPLEFT":
                    if (currentHeadPosition.getColNo() > mainBoard.getMinColNo() && currentHeadPosition.getRowNo() > mainBoard.getMinRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() - 1, currentHeadPosition.getColNo() - 1);
                    }
                    break;
                case "UPRIGHT":
                    if (currentHeadPosition.getColNo() < mainBoard.getMaxColNo() && currentHeadPosition.getRowNo() > mainBoard.getMinRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() - 1, currentHeadPosition.getColNo() + 1);
                    }
                    break;
                case "DOWNLEFT":
                    if (currentHeadPosition.getColNo() > mainBoard.getMinColNo() && currentHeadPosition.getRowNo() < mainBoard.getMaxRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() + 1, currentHeadPosition.getColNo() - 1);
                    }
                    break;
                case "DOWNRIGHT":
                    if (currentHeadPosition.getColNo() < mainBoard.getMaxColNo() && currentHeadPosition.getRowNo() < mainBoard.getMaxRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() + 1, currentHeadPosition.getColNo() + 1);
                    }
                    break;
            }

            if (newHeadPosition != null)
            {
                body.Insert(0, newHeadPosition); //Add a new head positon 0
                body.RemoveAt(body.Count-1); //Remove the last position
            }


        }
        public void draw()
        {
            for (int i=0;i<body.Count;i++)
            {
                mainBoard.draw(body[i], Properties.Resources.nyan_cat_rainbow_png_6);
            }

            mainBoard.draw(body[0], Properties.Resources.Nyan_Cat); //Index 0 is always the head
        }

        public Boolean checkEatItself()
        {
            Boolean result = false;

            if (body.Count > 1) //If snake is shorter then 1, sure won't eat itself
            {
                //Check if body[0] is at the same position as any one of the remaining body parts
                for (int i = 1; i < body.Count; i++)
                {
                    if (body[0].getRowNo() == body[i].getRowNo() && body[0].getColNo() == body[i].getColNo())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public Position getHeadPosition()
        {
            return body[0];
        }

        public void addToTail(Position p)
        {
            body.Add(p);
        }

        public void extendBody()
        {
            Position p = new Position(body[0].getRowNo(), body[0].getColNo());
            body.Insert(1, p);
        }
    }
}
