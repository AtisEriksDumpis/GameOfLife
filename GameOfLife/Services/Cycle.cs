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
            LifeTester neighbourCheck = new LifeTester();
            stepAray = new bool[inp, inp,games];
            for (int game=0;game<games;game++) {
                int checkIfAliveGame = neighbourCheck.counOfLiveCells[0];
                if (publicData.stopList.Contains(game)) continue;
                for (int row = 0; row < inp; row++)
                {
                    for (int column = 0; column < inp; column++)
                    {
                        stepAray[row, column, game] = neighbourCheck.calculateIfCellWillSurvive(arr, inp, row, column, game);
                    }
                }
                if (!checkIfAliveGame.Equals(neighbourCheck.counOfLiveCells[0])) neighbourCheck.counOfLiveCells[1]++;
            }
            return neighbourCheck.counOfLiveCells;
        }
    }
}
