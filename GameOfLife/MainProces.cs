using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    //Main task list for orderly exacution. One process to call all other classes 
    class MainProces
    {
        public void procOrd()
        {
            Setup setup = new Setup();
            Iteration iter = new Iteration();
            Drawer draw = new Drawer();

            Console.WriteLine("___GAME OF LIFE___");
            Console.WriteLine("Input size of matrix");
            int inp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inp);

            setup.frameSetup(inp);
            draw.drawCur(setup.cellBlock, inp);
            int f = 0;
            while (true)
            {
                f++;
                Console.WriteLine("\n Iteration count "+ f);
                //Console.WriteLine("\n Active count of live cells " + iter.liveCells);
                iter.updater(setup.cellBlock, inp);
                setup.cellBlock = iter.stepAray;
                draw.drawCur(setup.cellBlock, inp);
                Thread.Sleep(1000);
            }
            Console.WriteLine("beigasigues");


        }
    }
}
