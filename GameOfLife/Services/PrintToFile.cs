using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GameOfLife
{
    class PrintToFile
    {
        public void print(bool[,] cellBlock, int inp) {
            string path = @"C:\Users\atis.dumpis\Documents\Temp\GameOfLife.txt";
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("                                 ");
            int sum1 = 0;
            string textline;
            var line = new StringBuilder();
            line.Append(inp +" \n");
            for (int i = 0; i < inp; i++)
            {
                for (int j = 0; j < inp; j++)
                {
                    if (cellBlock[i, j]) sum1++;
                    line.Append(Convert.ToInt32(cellBlock[i, j])+ " ");
                }
                line.Append(" \n");

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
