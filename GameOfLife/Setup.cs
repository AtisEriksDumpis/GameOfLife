using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    //Class to set up the first game panel with random generation of cells
    class Setup
    {
        public int[,] cellBlock;

        public void frameSetup(int inp)
        {
            Random ran = new Random();
            cellBlock = new int[inp, inp];
            for (int i = 0; i < inp; i++)
            {
                for (int j = 0; j < inp; j++)
                {
                    cellBlock[i, j] = ran.Next(2);
                }
            }
        }
    }
}
