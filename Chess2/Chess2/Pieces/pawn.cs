using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class Pawn : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move)
        {
            int startX = move[0] - 'a';
            int startY = '8' - move[1];
            int endX = move[3] - 'a';
            int endY = '8' - move[4];
            //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
            if (startY == 6 && (endY == 4 || endY == 5))//allows piece to jump two on first turn
            {
                return true;
            }
            else if (startY != 6 && Char.IsWhiteSpace(board[startY - 1, startX]) && endY == (startY - 1) && endX == startX)//every other turn, one space forward
            {
                return true;
            }
            else if ((Char.IsLetter(board[startY - 1, startX - 1]) || Char.IsLetter(board[startY -1, startX + 1])) && (endY == startY -1 && (endX == startX + 1 || endX == startX -1)))
            {//allows attack on diagonal
                return true;
            }
            else//i decided to not add en passant, i would need to learn how to add classes :P
            {
                return false;
            }
        }
    }
}
