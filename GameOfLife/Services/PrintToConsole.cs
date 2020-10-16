using GameOfLife.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    //Class that draws any iterration given two dimensinal aray and size of one axes
    class PrintToConsole
    {
        public int itercount;
        public void drawCur(bool[,,] cellBlock, int inp, int games)
        {
            PublicData publicData = new PublicData();
            string textline;
            var line = new StringBuilder();

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("                                 ");
            for (int game = 0; game < games; game++)
            {
                //line.Append("\n curent game: " + (game+1) + "\n");
                int sum1 = 0;
                for (int i = 0; i < inp; i++)
                {

                    for (int j = 0; j < inp; j++)
                    {
                        if (cellBlock[i, j, game].Equals(1)) sum1++;
                        line.Append(Convert.ToInt32(cellBlock[i, j, game]));
                    }
                    textline = line.ToString();
                    Console.WriteLine("| " + textline + " |");
                }
                Console.WriteLine("\n " + publicData.liveCellCount + sum1);
                Console.WriteLine("\n " + publicData.iterrationCounter + itercount);
            }
        }

    }
}
