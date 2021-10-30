using System;

namespace quoridor
{
    class View
    {

        public void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++){
                for(int column = 0; column < field.GetLength(1); column++){
                    Console.Write(field[row, column] + " ");
                }
                Console.WriteLine();
            }
        }

        private void ClearConsole()
        {
            Console.Clear();
        }

        public string HandleConsoleInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if(input != ""){
                    return input;
                }
            }
        }
    }
}
