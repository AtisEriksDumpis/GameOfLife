using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GameOfLife
{
    class FilePrinter
    {
        public void print(bool[,,] cellBlock, int inp, int games) {
            string path = @"C:\Users\atis.dumpis\Documents\Temp\GameOfLife.txt";
            //Console.Clear();
            //Console.WriteLine("                                 ");
            int sum1 = 0;
            string textline;
            var line = new StringBuilder();
            line.Append(inp +" \n");
            for (int game = 0; game < games; game++)
            {
                line.Append("\n");
                for (int i = 0; i < inp; i++)
                {
                    for (int j = 0; j < inp; j++)
                    {
                        if (cellBlock[i, j, game]) sum1++;
                        line.Append(Convert.ToInt32(cellBlock[i, j, game]) + " ");
                    }
                    line.Append(" \n");

                }
            }
            textline = line.ToString();
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(textline);
                }
            }
        }
    }
}
