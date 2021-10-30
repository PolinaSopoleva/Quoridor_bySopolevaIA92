using System;
using System.Collections.Generic;

namespace Lab1.View
{
    public class View : IView
    {
        public void WriteStartInfo()
        {
            Console.WriteLine("You are playing Quoridor \nGame which made by Sopoleva");
        }

        public void WriteBoard(string[,] board)
        {
            for (var row = 0; row < board.GetLength(0); row++)
            {
                for (var column = 0; column < board.GetLength(1); column++)
                {
                    Console.Write(board[row, column]);
                }
                Console.Write("\n");
            }
        }

        public void WriteTurn()
        {
            Console.WriteLine("Choose a turn: \n 1 - Place a wall; \n 2 - Move yourself");
        }

        public void WritePossibleMoves(IEnumerable<string> moves)
        {
            var moveNumber = 1;
            foreach (var move in moves)
            {
                Console.WriteLine(moveNumber + move);
                moveNumber++;
            }
        }

        public void WriteWinner(string winner)
        {
            Console.WriteLine("PLAYER" + winner + "WIN!");
        }

        public void WriteWalls()
        {
            Console.WriteLine("Write position where you want to place the wall \n(ROW COLUMN direction(v/h))");
        }

        public void WriteGameMode()
        {
            Console.WriteLine("Choose a game mode: \n 1 - Against yourself \n 2 - Against bot");
        }
    }
}