using System.Collections;
using System.Collections.Generic;

namespace Lab1.View
{
    public interface IView
    {
        public void WriteStartInfo();
        public void WriteBoard(string[,] board);
        public void WritePossibleMoves(IEnumerable<string> moves);
        public void WriteWinner(string winner);
        public void WriteWalls();
        public void WriteGameMode();
        public void WriteTurn();
    }
}