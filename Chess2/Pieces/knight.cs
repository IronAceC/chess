using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class Knight : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move)
        {
            int startX = move[0] - 'a';
            int startY = '8' - move[1];
            int endX = move[3] - 'a';
            int endY = '8' - move[4];

            if (Char.IsUpper(board[endY,endX])) { return false; }

            if (startX + 2 == endX)
            {
                if (startY + 1 == endY) { return true; }
                else if (startY - 1 == endY) { return true; }
                else { return false; }
            }
            else if (startX - 2 == endX)
            {
                if (startY + 1 == endY) { return true; }
                else if (startY - 1 == endY) { return true; }
                else { return false; }
            }
            else if (startX + 1 == endX)
            {
                if (startY + 2 == endY) { return true; }
                else if (startY - 2 == endY) { return true; }
                else { return false; }
            }
            else if (startX - 1 == endX)
            {
                if (startY + 2 == endY) { return true; }
                else if (startY - 2 == endY) { return true; }
                else { return false; }
            }
            else { return false; }
        }
    }
}
