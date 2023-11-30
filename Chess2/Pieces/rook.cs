using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2.Pieces
{
    public class Rook : Fatherpiece
    {
        public static bool Raycast(char[,] board, string move)
        {
            int startX = move[0] - 'a';
            int startY = '8' - move[1];
            int endX = move[3] - 'a';
            int endY = '8' - move[4];

            if (startX != endX || startY == endY)//moving horizontally
            {
                if(startX > endX)//moving left
                {
                    bool mayI = false;
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
                    bool mayI = false;
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
                    bool mayI = false;
                    for (int i = startY - 1; i >= endY; i--)//looking ahead until we reach desired x
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
                    bool mayI = false;
                    for (int i = startY + 1; i >= endY; i++)//looking ahead until we reach desired x
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
                else {return false; }
            }
            else
            {
                return false;
            }
        }
    }
}
