using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace GameOfLife
{
    class FilePrinter
    {
        public void print(bool[,,] cellBlock, int inp, int games) {

            string path = AppDomain.CurrentDomain.BaseDirectory + "GameOfLife.txt";

            string textline;
            var line = new StringBuilder();
            line.Append(inp +" \n"+games+"\n");
            for (int game = 0; game < games; game++)
            {
                line.Append("\n");
                for (int i = 0; i < inp; i++)
                {
                    for (int j = 0; j < inp; j++)
                    {
                        line.Append(Convert.ToInt32(cellBlock[i, j, game]) + " ");
                    }
                    line.Append(" \n");
                }
            }
            textline = line.ToString();
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(textline);
            }
        }
    }
}
