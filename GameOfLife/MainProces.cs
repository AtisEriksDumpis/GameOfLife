using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    //Main task list for orderly exacution. One process to call all other classes 
    class MainProces
    {
        //public int inp;
        public void procOrd()
        {
            Setup setup = new Setup();
            Iteration iter = new Iteration();
            Drawer draw = new Drawer();
            PrintToFile prFile = new PrintToFile();
            SetupFromFile setFrom = new SetupFromFile();

            Console.WriteLine("___GAME OF LIFE___");
            Console.WriteLine("To contineu from last saved games instance pres f if not input size of matixes ege");
            string i = Console.ReadLine();
            draw.itercount = 0;
            if (i == "f")
            {
                setup.cellBlock = setFrom.prepFromFile();
            }
            else
            {
                setFrom.inp = Convert.ToInt32(i);
                setup.frameSetup(setFrom.inp);
            }


            draw.drawCur(setup.cellBlock, setFrom.inp);
            //int f = 0;
            do
            {
                while (!Console.KeyAvailable)
                {
                    draw.itercount++;
                    //Console.WriteLine("\n Active count of live cells " + iter.liveCells);
                    iter.updater(setup.cellBlock, setFrom.inp);
                    setup.cellBlock = iter.stepAray;
                    draw.drawCur(setup.cellBlock, setFrom.inp);
                    //var key = Console.ReadKey();
                    //if (key.Key == ConsoleKey.Escape)
                    //{
                    //    Environment.Exit(0);
                    //}
                    Console.WriteLine("Press ESC to stop"+ setFrom.inp);
                    //do

                    Thread.Sleep(1000);
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.WriteLine("to save to file press s key");
            string sinp = Console.ReadLine();
            if (sinp == "s")
            {
                prFile.print(setup.cellBlock, setFrom.inp);
            }


        }
    }
}
