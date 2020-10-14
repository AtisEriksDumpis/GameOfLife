using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    //Class that draws any iterration given two dimensinal aray and size of one axes
    class Drawer
    {
        public int itercount;
        public void drawCur(int[,] cellBlock, int inp)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("                                 ");
            int sum1 = 0;
            for (int i = 0; i < inp; i++)
            {
                string textline;
                var line = new StringBuilder();
                for (int j = 0; j < inp; j++)
                {
                    if (cellBlock[i, j].Equals(1)) sum1++;
                    line.Append(cellBlock[i, j]);
                }
                textline = line.ToString();
                Console.WriteLine("| " + textline + " |");
            }
            Console.WriteLine("\n live cells " + sum1);
            Console.WriteLine("\n Iterration counter: "+itercount);
        }

    }
}
