using GameOfLife.Data;
using GameOfLife.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{

    //Generate new step aray and fill it with calculated data of preveous generation
    class Cycle
    {
        //public aray for compareson reasons
        public bool[,,] stepAray;

        public int[] updater(bool[,,] arr, int inp, int games)
        {
            PublicData publicData = new PublicData();
            LifeTester lifeTester = new LifeTester();

            stepAray = new bool[inp, inp,games];
            for (int game=0;game<games;game++) {
                int checkIfAliveGame = lifeTester.counOfLiveCells[0];
                for (int row = 0; row < inp; row++)
                {
                    for (int column = 0; column < inp; column++)
                    {
                        stepAray[row, column, game] = lifeTester.calculateIfCellWillSurvive(arr, inp, row, column, game);
                    }
                }
                if (!checkIfAliveGame.Equals(lifeTester.counOfLiveCells[0])) lifeTester.counOfLiveCells[1]++;
            }
            return lifeTester.counOfLiveCells;
        }
    }
}
