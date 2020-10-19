using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    class FileSetup
    {
        public int matrixSize;
        public int paralelGameCount;
        public bool[,,] fileCellBlock;
        public bool[,,] prepFromFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "GameOfLife.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                matrixSize = 0;
                paralelGameCount = 0;
                int row = 0;
                int linecount = 0;
                //paralelGameCount = 2;
                //for (int k = 0; k < paralelGameCount*(matrixSize+1)+2; k++)
                //{
                while ((line = sr.ReadLine()) != null && (!row.Equals(matrixSize * paralelGameCount) || paralelGameCount.Equals(0)))
                {
                    if (matrixSize.Equals(0)) matrixSize = Convert.ToInt32(line);
                    else if (paralelGameCount.Equals(0))
                    {
                        paralelGameCount = Convert.ToInt32(line);
                        fileCellBlock = new bool[matrixSize, matrixSize, paralelGameCount];
                    }
                    else
                    {
                        if (!line.Length.Equals(0)){
                            string[] digets = line.Split(' ');
                            if (row == matrixSize)
                            {
                                row = 0;
                                linecount++;
                            }
                            for (int column = 0; column < matrixSize; column++)
                            {
                                fileCellBlock[row, column, linecount] = Convert.ToInt32(digets[column]).Equals(1);
                            }
                            row++;
                            //if (row % matrixSize == 0) linecount++;
                        }
                    }
                }


            }
            return fileCellBlock;
            // }
        }
            
    }
}

