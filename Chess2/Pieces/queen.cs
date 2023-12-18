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
                            if (Char.IsLetter(board[startY, startX]))
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
                            Console.WriteLine(i);
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
                        Console.WriteLine(i);
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
            else if (startX != endX || startY == endY)//moving horizontally
            {
                if (startX > endX)//moving left
                {
                    for (int i = startX - 1; i >= endX; i--)//looking ahead until we reach desired x
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
                        if (Char.IsLetter(board[startY, i]))//if thing ahead is a letter...
                        {
                            if (endX == i)//it's okay to replace the piece...
                            {
                                mayI = true;
                            }
                            else if (endX < i)//but not to go beyond it
                            {
                                mayI = false;
                            }
                            break;
                        }
                        else if (Char.IsWhiteSpace(board[startY, i]))//and we can keep going until there is nothing
                        {
                            mayI = true;
                        }

                    }
                    if (mayI == false)
                    {
                        return false;
                    }
                    else { return true; }


                }
                else if (startX < endX)//moving right
                {
                    for (int i = startX + 1; i <= endX; i++)//looking ahead until we reach desired x
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
                        if (Char.IsLetter(board[startY, i]))//if thing ahead is a letter...
                        {
                            if (endX == i)//it's okay to replace the piece...
                            {
                                mayI = true;
                            }
                            else if (endX > i)//but not to go beyond it
                            {
                                mayI = false;
                            }
                            break;
                        }
                        else if (Char.IsWhiteSpace(board[startY, i]))//and we can keep going until there is nothing
                        {
                            mayI = true;
                        }

                    }
                    if (mayI == false)
                    {
                        return false;
                    }
                    else { return true; }
                }
                else { return false; }

            }
            else if (startY != endY || startX == endX)//moving vertically
            {
                if (startY > endY)//moving down
                {
                    for (int i = startY - 1; i >= endY; i--)//looking ahead until we reach desired y
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
                        if (Char.IsLetter(board[i, startX]))//if thing ahead is a letter...
                        {
                            if (endY == i)//it's okay to replace the piece...
                            {
                                mayI = true;
                            }
                            else if (endY < i)//but not to go beyond it
                            {
                                mayI = false;
                            }
                            break;
                        }
                        else if (Char.IsWhiteSpace(board[i, startX]))//and we can keep going until there is nothing
                        {
                            mayI = true;
                        }

                    }
                    if (mayI == false)
                    {
                        return false;
                    }
                    else { return true; }
                }

                else if (startY < endY)//moving up
                {
                    for (int i = startY + 1; i >= endY; i++)//looking ahead until we reach desired y
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
                        if (Char.IsLetter(board[i, startX]))//if thing ahead is a letter...
                        {
                            if (endY == i)//it's okay to replace the piece...
                            {
                                mayI = true;
                            }
                            else if (endY < i)//but not to go beyond it
                            {
                                mayI = false;
                            }
                            break;
                        }
                        else if (Char.IsWhiteSpace(board[i, startX]))//and we can keep going until there is nothing
                        {
                            mayI = true;
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
