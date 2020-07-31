using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    

        public new static void UpdatePosition(string keyPressed, out int xCoordinate, out int yCoordinate)
        {
            yCoordinate = 0;
            xCoordinate = 0;

            switch (keyPressed)
            {
                case "RightArrow":
                xCoordinate++;
                break;
                case "D":
                xCoordinate++;
                break;
                case "LeftArrow":
                xCoordinate--;
                break;
                case "A":
                xCoordinate--;
                break;
                case "DownArrow":
                yCoordinate++;
                break;
                case "S":
                yCoordinate++;
                break;
                case "UpArrow":
                yCoordinate--;
                break;
                case "W":
                yCoordinate--;
                break;
                default:
                yCoordinate = 0;
                xCoordinate = 0;
                break;
                    }

            /*
            if (keyPressed.Equals("DownArrow"))
            {
                yCoordinate++;
            }
            else if (keyPressed.Equals("UpArrow"))
            {
                yCoordinate--;
            }
            else if (keyPressed.Equals("LeftArrow"))
            {
                xCoordinate--;
            }
            else if (keyPressed.Equals("Right Arrow"))
            {
                xCoordinate++;
            }
            */
            
        }

        public new static char UpdateCursor(string keyPressed)
        {
            switch (keyPressed)
            {
                case "LeftArrow":
                return '<';
                case "A":
                return '<';
                case "RightArrow":
                return '>';
                case "D":
                return '>';
                case "DownArrow":
                return 'v';
                case "S":
                return 'v';
                case "UpArrow":
                return '^';
                case "W":
                return '^';
            }
            return '>';
        }

        public new static int KeepInBounds(int coordinate, int maxBound)
        {
            if(coordinate >= maxBound)
            {
                coordinate = maxBound -1;
            }
            else if(coordinate <= 0)
            {
                coordinate = 0;
            }

            return coordinate;
        }

        public static int LoopAround(int coordinate, int maxBound)
        {
            if(coordinate >= maxBound)
            {
                coordinate = 0;
            }
            if(coordinate < 0)
            {
                coordinate = maxBound - 1;
            }
            return coordinate;
        } 

        public new static bool DidScore(int playerX, int playerY, int fruitX, int fruitY)
        {
            if(playerX == fruitX && playerY == fruitY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  }
}       