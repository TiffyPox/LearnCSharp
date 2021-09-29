using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private char[,] board;

        private int[][] winStates = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 3, 6, 9 },
            new int[] { 3, 5, 7 },
            new int[] { 1, 5, 9 },
        };
        private int count;

        public Board()
        {
            board = new char[3, 3];
        }
        public void GetBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c] = '-';
                }
            }
        }
        public void DisplayBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(board[r, c] + " ");
                }

                Console.WriteLine();
            }
        }
        public bool SetPosition(int position, char token)
        {
            var (row, column) = PositionToArrayCoordinate(position);
            if (board[row, column] == '-')
            {
                board[row, column] = token;
                count++;
                return true;
            }
            return false;
        }

        private (int row, int column) PositionToArrayCoordinate(int position)
        {
            return position switch
            {
                1 => (2, 0),
                2 => (2, 1),
                3 => (2, 2),
                4 => (1, 0),
                5 => (1, 1),
                6 => (1, 2),
                7 => (0, 0),
                8 => (0, 1),
                9 => (0, 2),
                _ => throw new Exception("Position not valid"),
            };
        }
        public bool CheckForWin()
        {
            foreach (var winState in winStates)
            {
                var (r1, c1) = PositionToArrayCoordinate(winState[0]);
                var (r2, c2) = PositionToArrayCoordinate(winState[1]);
                var (r3, c3) = PositionToArrayCoordinate(winState[2]);

                if (board[r1, c1] == '-')
                {
                    continue;
                }

                if (board[r1, c1] == board[r2, c2] && board[r1, c1] == board[r3, c3])
                {
                    return true;
                }
            }

            return false;
        }
        public bool CheckForDraw()
        {
            return count == 9;
        }
    }
}
