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
        public void drawCur(bool[,,] cellBlock, int inp, int games, int[] activeList, int[] liveCells)
        {
            PublicData publicData = new PublicData();
            string textline;
            var line = new StringBuilder();

            Console.Clear();
            Console.WriteLine(publicData.headerText);
            for (int game = 0; game < activeList.Length ; game=game+4)
            {
                
                int sum1 = 0;
                line.Clear();
                for (int i = 0; i < inp; i++)
                {

                    for (int j = 0; j < inp; j++)
                    {
                        if (game >= games)
                        {
                            line.Append("- ");
                        }
                        else
                        {
                            if (cellBlock[i, j, game].Equals(1)) sum1++;
                            line.Append(Convert.ToInt32(cellBlock[i, j, (activeList[game])]) + " ");
                        }
                    }
                    line.Append("      ");
                    for (int j = 0; j < inp; j++)
                    {
                        if (game >= (games-1))
                        {
                            line.Append("- ");
                        }
                        else
                        {
                            if (cellBlock[i, j, game+1].Equals(1)) sum1++;
                            line.Append(Convert.ToInt32(cellBlock[i, j, (activeList[game+1])]) + " ");
                        }
                    }
                    line.Append("      ");
                    for (int j = 0; j < inp; j++)
                    {
                        if (game >= (games-2))
                        {
                            line.Append("- ");
                        }
                        else
                        {
                            if (cellBlock[i, j, game+2].Equals(1)) sum1++;
                            line.Append(Convert.ToInt32(cellBlock[i, j, (activeList[game+2])]) + " ");
                        }
                    }
                    line.Append("      ");
                    for (int j = 0; j < inp; j++)
                    {
                        if (game >= (games - 3))
                        {
                            line.Append("- ");
                        }
                        else
                        {
                            if (cellBlock[i, j, game+3].Equals(1)) sum1++;
                            line.Append(Convert.ToInt32(cellBlock[i, j, (activeList[game + 3])]) + " ");
                        }
                    }
                    line.Append(" \n");

                }
                textline = line.ToString();
                Console.WriteLine(textline);
                if (sum1.Equals(0)) publicData.stopList.Add(game);
            }
            Console.WriteLine("Curently in total alive cells: " + liveCells[0] + "\nCUrently alive games: " + liveCells[1] + "\n");
            Console.WriteLine("\nCurently activly displayed games: \n Slot Nr1:[" + (activeList[0]+1) + "]  Slot Nr2:[" + (activeList[1] + 1) + "]  Slot Nr3:[" + (activeList[2] + 1) + "]  Slot Nr4:[" + (activeList[3] + 1) + "] \n\n Slot Nr5:[" + (activeList[4] + 1) + "]  Slot Nr6:[" + (activeList[5] + 1) + "]  Slot Nr7:[" + (activeList[6] + 1) + "]  Slot Nr8:[" + (activeList[7] + 1) + "] ");
        }

    }
}
