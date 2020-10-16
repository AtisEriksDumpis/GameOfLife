using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Services
{
    class NeighbourCheckers
    {
        public bool calculateIfCellWillSurvive(bool[,,] arr, int input, int row, int column, int game)
        {
            int sum = 0;
            if (row == 0)
            {
                if (column == 0) sum = Convert.ToInt32(arr[row, column + 1, game]) + Convert.ToInt32(arr[row + 1, column, game]) + Convert.ToInt32(arr[row + 1, column + 1, game]);
                else if (column == input - 1) sum = Convert.ToInt32(arr[row, column - 1, game]) + Convert.ToInt32(arr[row + 1, column - 1, game]) + Convert.ToInt32(arr[row + 1, column, game]);
                else sum = Convert.ToInt32(arr[row, column - 1, game]) + Convert.ToInt32(arr[row, column + 1, game]) + Convert.ToInt32(arr[row + 1, column - 1, game]) + Convert.ToInt32(arr[row + 1, column, game]) + Convert.ToInt32(arr[row + 1, column + 1, game]);
            }
            else if (row == input - 1)
            {
                if (column == 0) sum = Convert.ToInt32(arr[row - 1, column, game]) + Convert.ToInt32(arr[row - 1, column + 1, game]) + Convert.ToInt32(arr[row, column + 1, game]);
                else if (column == input - 1) sum = Convert.ToInt32(arr[row - 1, column - 1, game]) + Convert.ToInt32(arr[row - 1, column, game]) + Convert.ToInt32(arr[row, column - 1, game]);
                else sum = Convert.ToInt32(arr[row - 1, column - 1, game]) + Convert.ToInt32(arr[row - 1, column, game]) + Convert.ToInt32(arr[row - 1, column + 1, game]) + Convert.ToInt32(arr[row, column - 1, game]) + Convert.ToInt32(arr[row, column + 1, game]);
            }
            else
            {
                if (column == 0) sum = Convert.ToInt32(arr[row - 1, column, game]) + Convert.ToInt32(arr[row - 1, column + 1, game]) + Convert.ToInt32(arr[row, column + 1, game]) + Convert.ToInt32(arr[row + 1, column, game]) + Convert.ToInt32(arr[row + 1, column + 1, game]);
                else if (column == input - 1) sum = Convert.ToInt32(arr[row - 1, column - 1, game]) + Convert.ToInt32(arr[row - 1, column, game]) + Convert.ToInt32(arr[row, column - 1, game]) + Convert.ToInt32(arr[row + 1, column - 1, game]) + Convert.ToInt32(arr[row + 1, column, game]);
                else sum = Convert.ToInt32(arr[row - 1, column - 1, game]) + Convert.ToInt32(arr[row - 1, column, game]) + Convert.ToInt32(arr[row - 1, column + 1, game]) + Convert.ToInt32(arr[row, column - 1, game]) + Convert.ToInt32(arr[row, column + 1, game]) + Convert.ToInt32(arr[row + 1, column - 1, game]) + Convert.ToInt32(arr[row + 1, column, game]) + Convert.ToInt32(arr[row + 1, column + 1, game]);
            }
            if (Convert.ToInt32(arr[row, column, game]) == 1)
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
