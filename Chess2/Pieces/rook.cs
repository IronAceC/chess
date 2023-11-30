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
                    for (int i = startX - 1; i >= endX; i = i - 1)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(startX + " " + startY + " " + endX + " " + endY);
                        if (Char.IsLetter(board[startY, i]) == true)
                        {
                            if (endX < i)
                            {
                                Console.WriteLine("1");
                                return false;
                            }
                            else if (endX == i)
                            {
                                Console.WriteLine("2");
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("3");
                                return false;
                            }
                        }
                        else if (Char.IsWhiteSpace(board[startY, i]))
                        {
                            Console.WriteLine("4");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("5");
                            return false;
                        }
                    }
                    return true;

                }
                else if (startX < endX)//moving right
                {
                    return true;
                }
                else { return false; }

            }
            else if (startY != endY || startX == endX)//moving vertically
            {
                if (startY > endY)//moving down
                {
                    return true;
                }

                else if (startY < endY)//moving up
                {
                    return true;
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
