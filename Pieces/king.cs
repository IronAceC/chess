using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class King : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move, char[,] board2)
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
                else if (startY == endY)
                {
                    mayI = true;
                }
                else if (startY - 1 == endY)
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
                else if (startY - 1 == endY)
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
                else if (startY == endY)
                {
                    mayI = true;
                }
                else if (startY - 1 == endY)
                {
                    mayI = true;
                }
                else
                {
                    mayI = false;
                }
            }
            else if ((board[7,5] == ' ' && board[7,6] == ' ' && board[7,7] == 'R' && board[7,4] == 'K') || (board[7,4] == 'K' && board[7,3] == ' ' && board[7,2] == ' ' && board[7,1] == ' ' && board[7,0] == 'R') || (board[7,3] == 'K' && board[7,2] == ' ' && board[7,1] == ' ' && board[7,0] == 'R') || (board[7,3] == 'K' && board[7,4] == ' ' && board[7,5] == ' ' && board[7,6] == ' ' && board[7,7] == 'R'))
            {
                if (board[7,4] == 'K')
                {
                    if (startX + 2 == endX && board[7, 5] == ' ' && board[7, 6] == ' ' && board[7, 7] == 'R')
                    {
                        board[7, startX + 1] = 'R';
                        board[7, 7] = ' ';
                        board2[0, 0] = ' ';
                        board2[0, -(startX + 1) + 7] = 'r';
                        mayI = true;
                    }
                    else if (startX - 2 == endX && board[7, 3] == ' ' && board[7, 2] == ' ' && board[7, 1] == ' ' && board[7, 0] == 'R')
                    {
                        board[7, 0] = ' ';
                        board[7, startX - 1] = 'R';
                        board2[0, 7] = ' ';
                        board2[0, -(startX - 1) + 7] = 'r';
                        mayI = true;
                    }
                    else { mayI = false; }
                }
                else if (board[7,3] == 'K')
                {
                    if (startX +2 == endX && board[7, 4] == ' ' && board[7, 5] == ' ' && board[7, 6] == ' ' && board[7, 7] == 'R')
                    {
                        board[7, startX + 1] = 'R';
                        board[7, 7] = ' ';
                        board2[0, 0] = ' ';
                        board2[0, -(startX + 1) + 7] = 'r';
                        mayI = true;
                    }
                    else if (startX -2 == endX && board[7, 2] == ' ' && board[7, 1] == ' ' && board[7, 0] == 'R')
                    {
                        board[7, 0] = ' ';
                        board[7, startX - 1] = 'R';
                        board2[0, 7] = ' ';
                        board2[0, -(startX - 1) + 7] = 'r';
                        mayI = true;
                    }
                    else { mayI = false; };
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
