using System.Collections.Generic;

namespace Lab1.Controller
{
    public interface IModel
    {
        public void StartGame();
        public string[,] GetBoard();
        public IEnumerable<string> GetPossibleMoves(int playerNumb);
        public bool CheckWin();
        public void MakeMove(int playerNumb, Cell cell);
        public void PlaceWall(int playerNumb, Cell cell, string orientation);
        public bool IsWallsLeft(int playerNumb);
    }
}