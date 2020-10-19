using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Services
{
    class GameSelector
    {
        public int selectGame(bool[,,] printMas, int games, int matrixSize)
        {
            int game = 0;
            do
            {
                if (game >= games) game = 0;
                var line = new StringBuilder();
                for (int row = 0; row < matrixSize; row++)
                {
                    for (int column = 0; column < matrixSize; column++)
                    {
                        line.Append(Convert.ToInt32(printMas[row, column, game]) + " ");
                    }
                    line.Append("\n");
                }
                Console.Clear();
                string textLine = line.ToString();
                Console.WriteLine("Game Nr:" + (game + 1));
                Console.WriteLine(textLine + "\n\n If selected game is acseptible pres [Y] else press arow key [>]");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:
                        
                        break;
                    case ConsoleKey.Y:
                        return game;
                }
                game++;

            } while(true);
        }
    }
}
