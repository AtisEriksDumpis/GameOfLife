using GameOfLife.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{

    //Generate new step aray and fill it with calculated data of preveous generation
    class Iteration
    {
        //public aray for compareson reasons
        public bool[,,] stepAray;

        public void updater(bool[,,] arr, int inp, int games)
        {
            NeighbourCheckers neighbourCheck = new NeighbourCheckers();
            stepAray = new bool[inp, inp,games];
            for (int game=0;game<games;game++) {
                for (int row = 0; row < inp; row++)
                {
                    for (int column = 0; column < inp; column++)
                    {

                        stepAray[row, column, game] = neighbourCheck.calculateIfCellWillSurvive(arr, inp, row, column, game);

                    }
                }
            }
        }
    }
}
