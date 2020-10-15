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
        public bool[,] stepAray;

        public void updater(bool[,] arr, int inp)
        {
            NeighbourCheckers neighbourCheck = new NeighbourCheckers();
            stepAray = new bool[inp, inp];
            for (int row = 0; row < inp; row++)
            {
                for (int column = 0; column < inp; column++)
                {

                    stepAray[row, column] = neighbourCheck.calculateIfCellWillSurvive(arr,inp,row,column);

                }
            }
        }
    }
}
