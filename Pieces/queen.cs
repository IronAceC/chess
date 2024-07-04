using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class Queen : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move)
        {
            int startX = move[0] - 'a';
            int startY = '8' - move[1];
            int endX = move[3] - 'a';
            int endY = '8' - move[4];
            bool mayI = false;
            //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
            if (startX != endX && startY != endY) //diagonal moves
            {
                if (startX < endX) //moving right
                {
                    if (startY > endY)//moving up & right
                    {
                        if (endX - startX != startY - endY)
                        {
                            mayI = false;
                        }
                        else
                        {
                            for (int i = (startX - endX); i <= 0; i++)
                            {
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

                    else if (startY < endY) //moving down and right
                    {
                        if (endX - startX != endY - startY)
                        {
                            mayI = false;
                        }
                        else
                        {
                            for (int i = (startX - endX); i <= 0;i++)
                            {
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
                }
                if (startX > endX) //moving left
                {
                    if (startY > endY)//moving up & left
                    {
                        if (startX - endX != startY - endY)
                        {
                            mayI = false;
                        }
                        else
                        {
                            for (int i = (endX - startX); i <= 0; i++)
                            {
                                startX -= 1;
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

                    else if (startY < endY) //moving down and left
                    {
                        if (startX - endX != endY - startY)
                        {
                            mayI = false;
                        }
                        else
                        {
                            for (int i = (endX - startX); i <= 0; i++)
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
                }
            }
            else if (startX != endX || startY != endY)
            {
                if (startX == endX) // moving vertically
                {
                    if (startY < endY) // moving up
                    {
                        for (int i = (startY - endY); i <= 0; i++)
                        {
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
                    else if (startY > endY) //moving down
                    {
                        for (int i = (endY - startY); i <= 0; i++)
                        {
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
                else if (startY == endY)//moving horizontally
                {
                    if (startX < endX) // moving right
                    {
                        for (int i = (startX - endX); i <= 0; i++)
                        {
                            startX += 1;
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
                    else if (startX > endX) //moving left
                    {
                        for (int i = (endX - startX); i <= 0; i++)
                        {
                            startX -= 1;
                            if(startX == endX)
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



