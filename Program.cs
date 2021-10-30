using System;

namespace quoridor
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new View();
            char[,] field = new char[,] {
                {'1', '2', '3', '4', '5'},
                {'1', '2', '3', '4', '5'},
                {'1', '2', '3', '4', '5'},
                {'1', '2', '3', '4', '5'},
                {'1', '2', '3', '4', '5'},
                {'1', '2', '3', '4', '5'}
            };
            char[,] field2 = new char[,] {
                {'1', 'd', '3', '4', '5'},
                {'1', '2', '3', '4', '5'},
                {'1', '2', '6', '4', '5'},
                {'1', '8', '3', '4', '5'},
                {'1', '2', '8', '9', '5'},
                {'1', '2', '3', '4', '5'}
            };

            view.PrintField(field);
            view.PrintField(field2);
        }
    }
}
