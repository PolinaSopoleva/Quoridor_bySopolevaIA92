using System;
using Lab1.View;

namespace Lab1.Controller
{
    public class Controller
    {
        private readonly IModel _model;
        private readonly IView _view;
        private bool _playerNumber;

        public Controller(IModel model, IView view)
        {
            _model = model;
            _view = view;
        }

        public void StartGame()
        {
            _view.WriteStartInfo();
            _model.StartGame();
            HandleTurn();
        }

        private void HandleTurn()
        {
            while (true)
            {
                if (_model.CheckWin())
                {
                    _view.WriteWinner(GetPlayerNumber());
                    StartGame();
                    return;
                }
                _view.WriteBoard(_model.GetBoard());
                _view.WriteTurn();
                var input = HandleInput();
                switch (input[0])
                {
                    case "1":
                        if (_model.IsWallsLeft(int.Parse(GetPlayerNumber())))
                        {
                            HandleWallPlacement();
                        }
                        else
                        {
                            Console.WriteLine("You don`t have walls!");
                            HandleTurn();
                        }
                        return;
                    case "2":
                        HandleMove();
                        return;
                    default:
                        HandleTurn();
                        return;
                }
            }
        }

        private void HandleWallPlacement()
        {
            while (true)
            {
                try
                {
                    _view.WriteBoard(_model.GetBoard());
                    _view.WriteWalls();
                    var input = HandleInput();
                    _model.PlaceWall(int.Parse(GetPlayerNumber()), new Cell(int.Parse(input[0]), int.Parse(input[1])), input[2]);
                    SwapPlayers();
                    HandleTurn();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    HandleWallPlacement();
                }
            }
        }

        private void HandleMove()
        {
            while (true)
            {
                try
                {
                    _view.WriteBoard(_model.GetBoard());
                    _view.WritePossibleMoves(_model.GetPossibleMoves(int.Parse(GetPlayerNumber())));
                    var input = HandleInput();
                    _model.MakeMove(int.Parse(GetPlayerNumber()), new Cell(int.Parse(input[0]), int.Parse(input[1])));
                    SwapPlayers();
                    HandleTurn();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    HandleMove();
                }
                
            }
            
        }

        private static string[] HandleInput()
        {
            while (true)
            {
                var input = Console.ReadLine()?.Split(" ");
                if (input?.Length > 0)
                {
                    Console.Clear();
                    return input;
                }
                Console.WriteLine("Empty input, try one time more!");
            }
        }

        private string GetPlayerNumber()
        {
            return _playerNumber ? "1" : "2";
        }

        private void SwapPlayers()
        {
            _playerNumber = !_playerNumber;
        }
    }
}