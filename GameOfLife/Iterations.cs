using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{

    //Generate new step aray and fill it with calculated data of preveous generation
    class Iteration
    {
        //public aray for compareson reasons
        public int[,] stepAray;
        public int liveCells;

        public void updater(int[,] arr, int inp)
        {
            stepAray = new int[inp, inp];
            //liveCells = 0;
            for (int i = 0; i < inp; i++)
            {
                for (int j = 0; j < inp; j++)
                {
                    int sum = 0;
                    if (i == 0)
                    {
                        if (j == 0) sum = arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                        else if (j == inp - 1) sum = arr[i, j - 1] + arr[i + 1, j - 1] + arr[i + 1, j];
                        else sum = arr[i, j - 1] + arr[i, j + 1] + arr[i + 1, j - 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                    }
                    else if (i == inp - 1)
                    {
                        if (j == 0) sum = arr[i - 1, j] + arr[i - 1, j + 1] + arr[i, j + 1];
                        else if (j == inp - 1) sum = arr[i - 1, j - 1] + arr[i - 1, j] + arr[i, j - 1];
                        else sum = arr[i - 1, j - 1] + arr[i - 1, j] + arr[i - 1, j + 1] + arr[i, j - 1] + arr[i, j + 1];
                    }
                    else
                    {
                        if (j == 0) sum = arr[i - 1, j] + arr[i - 1, j + 1] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                        else if (j == inp - 1) sum = arr[i - 1, j - 1] + arr[i - 1, j] + arr[i, j - 1] + arr[i + 1, j - 1] + arr[i + 1, j];
                        else sum = arr[i - 1, j - 1] + arr[i - 1, j] + arr[i - 1, j + 1] + arr[i, j - 1] + arr[i, j + 1] + arr[i + 1, j - 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                    }
                    if (arr[i, j] == 1)
                    {
                        if (sum == 2 || sum == 3) 
                        { 
                            stepAray[i, j] = 1;
                            //liveCells++;
                        }
                        else stepAray[i, j] = 0;
                    }
                    else
                    {
                        if (sum == 3)
                        {
                            stepAray[i, j] = 1;
                            //liveCells++;
                        }
                        else stepAray[i, j] = 0;
                    }


                }
            }
        }
    }
}
