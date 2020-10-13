using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    //Class that draws any iterration given two dimensinal aray and size of one axes
    class Drawer
    {
        public void drawCur(int[,] cellBlock, int inp)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("                                 ");
            for (int i = 0; i < inp; i++)
            {
                string textline;
                var line = new StringBuilder();
                for (int j = 0; j < inp; j++)
                {
                    line.Append(cellBlock[i, j]);
                }
                textline = line.ToString();
                Console.WriteLine("| " + textline + " |");
            }
        }

    }
}
