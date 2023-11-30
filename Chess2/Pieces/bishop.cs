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


            return true;
        }
    }
}
