using Chess2.Pieces;
using System;
//main part of the chess game
//aiden krahn, 2023
class ChessGame
{
    

    static void InitializeBoard(char[,] board)//<--- char[,] boardis in main
    {
        // put pieces on board: uppercase is person that is going to move, lowercase is other

        // fill the board with spaces for empty squares
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = ' ';
            }
        }

        // place opponent pieces
        board[0, 0] = 'r';
        board[0, 1] = 'n';
        board[0, 2] = 'b';
        board[0, 3] = 'q';
        board[0, 4] = 'k';
        board[0, 5] = 'b';
        board[0, 6] = 'n';
        board[0, 7] = 'r';

        for (int i = 0; i < 8; i++)
        {
            board[1, i] = 'p';
        }

        // place your pieces
        board[7, 0] = 'R';
        board[7, 1] = 'N';
        board[7, 2] = 'B';
        board[7, 3] = 'Q';
        board[7, 4] = 'K';
        board[7, 5] = 'B';
        board[7, 6] = 'N';
        board[7, 7] = 'R';

        for (int i = 0; i < 8; i++)
        {
            board[6, i] = 'P';
        }
    }

    static void PrintBoard(char[,] board)//<-- char[,] board is in main
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
    }

    static bool IsMoveValid(char[,] board, string move)
    {

        if (move.Length != 5 || move[2] != ' ')
        {
            return false;
        }

        int startX = move[0] - 'a';
        int startY = '8' - move[1];
        
        if (startX < 0 || startX >= 8 || startY < 0 || startY >= 8 || Char.IsWhiteSpace(board[startY, startX]) || Char.IsLower(board[startY, startX]))
        {
            return false;
        }
        char v = board[startY, startX];
        Console.WriteLine(v);

        bool result = v.Equals('P');
        if (result == true)
        {
            //Console.WriteLine("Am I working");
            return Pawn.Raycast(board, move);
        }

        // add more specific move validation here


        return true;
    }

    static void ApplyMove(char[,] board1, string move, char[,] board2)
    {
        // Apply the move to update the board
        int startX = move[0] - 'a';
        int startY = '8' - move[1];
        int endX = move[3] - 'a';
        int endY = '8' - move[4];
        //Console.WriteLine(startX);
        //Console.WriteLine(startY);
        //Console.WriteLine(endX);
        //Console.WriteLine(endY);

        char piece1 = board1[startY, startX];

        board1[startY, startX] = ' ';//deletes where piece was
        board1[endY, endX] = piece1;

        //when moves are applied to board2, they have to be flipped. remember how to use graphing and algebra?
        startX = -1 * startX + 7;
        startY = -1 * startY + 7;
        endX = -1 * endX + 7;
        endY = -1 * endY + 7;

        char piece2 = board2[startY, startX];

        board2[startY, startX] = ' ';
        board2[endY, endX] = piece2;

    }
    static void Main()
    {
        // Initialize the blank chess board.
        char[,] board1 = new char[8, 8];
        char[,] board2 = new char[8, 8];

        //see definition to watch it add pieces to board
        InitializeBoard(board1);

        InitializeBoard(board2);

        board2[7, 3] = 'K';
        board2[7, 4] = 'Q';
        board2[0, 3] = 'k';
        board2[0, 4] = 'q';

        // Game loop
        int blackzero = 1;//black moves when this variable is zero (get it?)
        while (true)
        {
            if (blackzero == 1)
            {
                PrintBoard(board1);
                Console.WriteLine("White, Enter your move: ");
                string move = Console.ReadLine();

                if (IsMoveValid(board1, move))
                {
                    // Apply the move
                    ApplyMove(board1, move, board2);

                    // Display the updated board
                    PrintBoard(board1);


                    blackzero = 0;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }

            if (blackzero == 0)
            {
                PrintBoard(board2);
                Console.WriteLine("Black, Enter your move: ");
                string move2 = Console.ReadLine();

                if (IsMoveValid(board2, move2))
                {
                    // Apply the move
                    ApplyMove(board2, move2, board1);

                    // Display the updated board
                    PrintBoard(board2);
                    blackzero = 1;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }


            }
        }
    }
}