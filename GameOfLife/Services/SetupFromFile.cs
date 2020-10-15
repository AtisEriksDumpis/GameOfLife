using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    class SetupFromFile
    {
        public int inp;
        public bool[,] fileCellBlock;
        public bool[,] prepFromFile()
        {
            //Setup set = new Setup();

            string path = @"C:\Users\atis.dumpis\Documents\Temp\GameOfLife.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                inp = 0;
                int counter = 0;
                
                while ((line = sr.ReadLine()) != null && !counter.Equals(5))
                {
                    if (inp.Equals(0)) 
                    { 
                        inp = Convert.ToInt32(line);
                        fileCellBlock = new bool[inp, inp];
                    }
                    else
                    {
                        string[] digets = line.Split(' ');

                        for (int j = 0; j < inp; j++)
                        {
                            fileCellBlock[counter, j] = Convert.ToInt32(digets[j]).Equals(1);
                        }
                        counter++;
                    }


                }
            }
            return fileCellBlock;
        }
    }
}
