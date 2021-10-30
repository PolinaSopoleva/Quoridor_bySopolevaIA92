using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Board
    {
        Space[,] board = new Space[9, 9];

        public Board(bool twoPlayerGame)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    bool farRight = j == 8 ? true : false;
                    bool farBottom = i == 8 ? true : false;
                    board[i, j] = new Space(farRight, farBottom);
                }
            }
        }
        //Just like the Quoridor wikipedia article, each wall placed is given a square (row and column) and an orientation (h/v)
        //the row/col is determined by the space to the top-left of the wall being placed
        //        >[]|[] >[][]    the arrow is pointing to the space that corresponds to that wall (left one is vertical, right one is horizontal)
        //         []|[]  ----
        //                [][] 
        //horizontal: true->horizontal wall, false->vertical wall
        //row and col: coordinates for the wall-defining space
        public void placeWall(bool horizontal, int row, int col)
        {
            if (row < 8 && col < 8)
            {
                board[row, col].AddWall(horizontal);
                if (horizontal)
                {
                    board[row, col + 1].AddWall(horizontal);
                }
                else
                {
                    board[row + 1, col].AddWall(horizontal);
                }
            }
        }

        //This allows things like this to happen:
        //Board board = new Board();
        //board[3,4].AddWall(true);
        //board[2,5].Occupied = 0;
        public Space this[int row, int col]
        {
            get
            {
                return board[row, col];
            }
        }
    }
}
