using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Services
{
    class NeighbourCheckers
    {
        public bool calculateIfCellWillSurvive(bool[,] arr, int input, int row, int column)
        {
            int sum = 0;
            if (row == 0)
            {
                if (column == 0) sum = Convert.ToInt32(arr[row, column + 1]) + Convert.ToInt32(arr[row + 1, column]) + Convert.ToInt32(arr[row + 1, column + 1]);
                else if (column == input - 1) sum = Convert.ToInt32(arr[row, column - 1]) + Convert.ToInt32(arr[row + 1, column - 1]) + Convert.ToInt32(arr[row + 1, column]);
                else sum = Convert.ToInt32(arr[row, column - 1]) + Convert.ToInt32(arr[row, column + 1]) + Convert.ToInt32(arr[row + 1, column - 1]) + Convert.ToInt32(arr[row + 1, column]) + Convert.ToInt32(arr[row + 1, column + 1]);
            }
            else if (row == input - 1)
            {
                if (column == 0) sum = Convert.ToInt32(arr[row - 1, column]) + Convert.ToInt32(arr[row - 1, column + 1]) + Convert.ToInt32(arr[row, column + 1]);
                else if (column == input - 1) sum = Convert.ToInt32(arr[row - 1, column - 1]) + Convert.ToInt32(arr[row - 1, column]) + Convert.ToInt32(arr[row, column - 1]);
                else sum = Convert.ToInt32(arr[row - 1, column - 1]) + Convert.ToInt32(arr[row - 1, column]) + Convert.ToInt32(arr[row - 1, column + 1]) + Convert.ToInt32(arr[row, column - 1]) + Convert.ToInt32(arr[row, column + 1]);
            }
            else
            {
                if (column == 0) sum = Convert.ToInt32(arr[row - 1, column]) + Convert.ToInt32(arr[row - 1, column + 1]) + Convert.ToInt32(arr[row, column + 1]) + Convert.ToInt32(arr[row + 1, column]) + Convert.ToInt32(arr[row + 1, column + 1]);
                else if (column == input - 1) sum = Convert.ToInt32(arr[row - 1, column - 1]) + Convert.ToInt32(arr[row - 1, column]) + Convert.ToInt32(arr[row, column - 1]) + Convert.ToInt32(arr[row + 1, column - 1]) + Convert.ToInt32(arr[row + 1, column]);
                else sum = Convert.ToInt32(arr[row - 1, column - 1]) + Convert.ToInt32(arr[row - 1, column]) + Convert.ToInt32(arr[row - 1, column + 1]) + Convert.ToInt32(arr[row, column - 1]) + Convert.ToInt32(arr[row, column + 1]) + Convert.ToInt32(arr[row + 1, column - 1]) + Convert.ToInt32(arr[row + 1, column]) + Convert.ToInt32(arr[row + 1, column + 1]);
            }
            if (Convert.ToInt32(arr[row, column]) == 1)
            {
                if (sum == 2 || sum == 3)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                if (sum == 3) return true;
                else return false;
            }
        }
    }
}
