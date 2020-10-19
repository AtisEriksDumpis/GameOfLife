using GameOfLife.Data;
using GameOfLife.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    //Class that draws any iterration given two dimensinal aray and size of one axes
    class ConsolePrinter
    {
        public int itercount;
        public void drawCurentState(bool[,,] cellBlock, int inp, int games, int[] activeList, int[] liveCells)
        {
            PublicData publicData = new PublicData();

            string textLine;
            var line = new StringBuilder();
            Console.Clear();
            Console.WriteLine(publicData.headerText);
            for (int game = 0; game < activeList.Length ; game=game+4)
            {
                line.Clear();
                for (int row = 0; row < inp; row++)
                {

                    for (int column = 0; column < inp; column++)
                    {
                        if (game >= games) line.Append("- ");
                        else line.Append(Convert.ToInt32(cellBlock[row, column, (activeList[game])]) + " ");
                    }
                    line.Append("      ");
                    for (int column = 0; column < inp; column++)
                    {
                        if (game >= (games-1)) line.Append("- ");
                        else line.Append(Convert.ToInt32(cellBlock[row, column, (activeList[game+1])]) + " ");
                    }
                    line.Append("      ");
                    for (int column = 0; column < inp; column++)
                    {
                        if (game >= (games-2)) line.Append("- ");
                        else line.Append(Convert.ToInt32(cellBlock[row, column, (activeList[game+2])]) + " ");
                    }
                    line.Append("      ");
                    for (int column = 0; column < inp; column++)
                    {
                        if (game >= (games - 3)) line.Append("- ");
                        else line.Append(Convert.ToInt32(cellBlock[row, column, (activeList[game + 3])]) + " ");
                    }
                    line.Append(" \n");

                }
                textLine = line.ToString();
                Console.WriteLine(textLine);
            }
            Console.WriteLine("Curently in total alive cells: " + liveCells[0] + "\nCUrently alive games: " + liveCells[1] + "\n");
            Console.WriteLine("\nCurently activly displayed games: \n Slot Nr1:[" + (activeList[0]+1) + "]  Slot Nr2:[" + (activeList[1] + 1) + "]  Slot Nr3:[" + (activeList[2] + 1) + "]  Slot Nr4:[" + (activeList[3] + 1) + "] \n\n Slot Nr5:[" + (activeList[4] + 1) + "]  Slot Nr6:[" + (activeList[5] + 1) + "]  Slot Nr7:[" + (activeList[6] + 1) + "]  Slot Nr8:[" + (activeList[7] + 1) + "] ");
        }

    }
}
