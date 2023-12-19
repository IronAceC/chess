using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class Bishop : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move)
        {
            int startX = move[0] - 'a';
            int startY = '8' - move[1];
            int endX = move[3] - 'a';
            int endY = '8' - move[4];
            bool mayI = false;
            //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);

            if (endX < startX)//moving left
            {
                if (endY < startY)//and moving up
                {
                    if (startX - endX != startY - endY)//if they don't go exactly diagonal
                    {
                        mayI = false; 
                    }
                    else
                    {
                        for (int i = -(startX - endX); i <= 0; i++)
                        {
                            startX -= 1;
                            startY -= 1;
                            if (startX == endX)
                            {
                                mayI = true; break;
                            }
                            if (Char.IsLetter(board[startY,startX]))
                            {
                                mayI = false; break;
                            }
                        }
                    }
                    
                }
                else if (endY > startY)//moving down
                {
                    if (startX - endX != endY - startY)
                    {
                        mayI = false;
                    }
                    for (int i = startX - endX; i >= 0; i--)
                    {
                        startX -= 1;
                        startY += 1;
                        if (startX == endX)
                        {
                            mayI = true; break;
                        }
                        if (Char.IsLetter(board[startY, startX]))
                        {
                            mayI = false; break;
                        }
                    }
                }
            }
            else if (endX > startX)//moving right
            {
                if (endY < startY)//and moving up
                {
                    if (endX - startX != startY - endY)//if they don't go exactly diagonal
                    {
                        mayI = false;
                    }
                    else
                    {
                        for (int i = -(endX - startX); i <= 0; i++)
                        {
                            //Console.WriteLine(i);
                            startX += 1;
                            startY -= 1;
                            if (startX == endX)
                            {
                                mayI = true; break;
                            }
                            if (Char.IsLetter(board[startY, startX]))
                            {
                                mayI = false; break;
                            }
                        }
                    }

                }
                else if (endY > startY)//moving down
                {
                    if (endX - startX != endY - startY)
                    {
                        mayI = false;
                    }
                    for (int i = startX - endX; i <= 0; i++)
                    {
                        //Console.WriteLine(i);
                        startX += 1;
                        startY += 1;
                        if (startX == endX)
                        {
                            mayI = true; break;
                        }
                        if (Char.IsLetter(board[startY, startX]))
                        {
                            mayI = false; break;
                        }
                    }
                }
            }
            

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
