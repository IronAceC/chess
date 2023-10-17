using System;

class ChessGame
{
    static void Main()
    {
        // Initialize the blank chess board.
        char[,] board = new char[8, 8];
        //see definition to watch it add pieces to board
        InitializeBoard(board);

        // Display the board.
        PrintBoard(board);

        // Game loop
        int blackzero = 1;//black moves when this variable is zero (get it?)
        while (true)
        {
            if (blackzero == 1)
            {
                Console.WriteLine("Enter your move: ");
                string move = Console.ReadLine();

                if (IsMoveValid(board, move))
                {
                    // Apply the move
                    ApplyMove(board, move);

                    // Display the updated board
                    PrintBoard(board);

                    blackzero = 0;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
            
            if (blackzero == 0)
            {
                Console.WriteLine("Enter your move: ");
                string move2 = Console.ReadLine();

                if (IsMoveValid(board, move2))
                {
                    // Apply the move
                    ApplyMove(board, move2);

                    // Display the updated board
                    PrintBoard(board);
                    blackzero = 1;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }

            
            }
        }
    }

    static void InitializeBoard(char[,] board)
    {
        // Put pieces on board: uppercase is white, lowercase is black

        // Fill the board with spaces for empty squares
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = ' ';
            }
        }

        // Place white pieces
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

        // Place black pieces
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

    static void PrintBoard(char[,] board)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IsMoveValid(char[,] board, string move)
    {
        // Add movement parameters here

        if (move.Length != 5 || move[2] != ' ')
        {
            return false;
        }

        int startX = move[0] - 'a';
        int startY = '8' - move[1];//add if statement here to put blackzero to work: detect if piece at coordinate is up/low case and respond accordingly
        if (startX < 0 || startX >= 8 || startY < 0 || startY >= 8 || Char.IsWhiteSpace(board[startY, startX]))
        {
            return false;
        }

        // Add more specific move validation here


        return true;
    }

    static void ApplyMove(char[,] board, string move)
    {
        // Apply the move to update the board
        int startX = move[0] - 'a';
        int startY = '8' - move[1];
        int endX = move[3] - 'a';
        int endY = '8' - move[4];

        char piece = board[startY, startX];

        board[startY, startX] = ' ';//deletes where piece was
        board[endY, endX] = piece;
    }
}
