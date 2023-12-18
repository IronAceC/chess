using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class King : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move)
        {
            int startX = move[0] - 'a';
            int startY = '8' - move[1];
            int endX = move[3] - 'a';
            int endY = '8' - move[4];
            bool mayI = false;
            if (startX + 1 == endX)
            {
                if (startY + 1 == endY)
                {
                    mayI = true;
                }
                if (startY == endY)
                {
                    mayI = true;
                }
                if (startY - 1 == endY)
                {
                    mayI = true;
                }
                else
                {
                    mayI = false;
                }
            }
            else if (startX == endX)
            {
                if (startY + 1 == endY)
                {
                    mayI = true;
                }
                if (startY == endY)
                {
                    mayI = true;
                }
                if (startY - 1 == endY)
                {
                    mayI = true;
                }
                else
                {
                    mayI = false;
                }
            }
            else if (startX - 1 == endX)
            {
                if (startY + 1 == endY)
                {
                    mayI = true;
                }
                if (startY == endY)
                {
                    mayI = true;
                }
                if (startY - 1 == endY)
                {
                    mayI = true;
                }
                else
                {
                    mayI = false;
                }
            }
            else { mayI = false; }
            if (mayI == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
