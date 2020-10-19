using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    //Class to set up the first game panel with random generation of cells
    class RandomSetup
    {
        public bool[,,] cellBlock;

        public void frameSetup(int input,int paralGameCount)
        {
            Random ran = new Random();
            cellBlock = new bool[input, input, paralGameCount];
            for (int game = 0; game < paralGameCount; game++)
            {
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j < input; j++)
                    {
                        cellBlock[i, j, game] = (ran.Next(2)).Equals(1);
                    }
                }
            }
        }
    }
}
