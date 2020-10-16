using GameOfLife.Data;
using GameOfLife.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    //Main task list for orderly exacution. One process to call all other classes 
    class MainProces
    {
        public bool threadstop = true;
        public void procOrd()
        {
            SetupRandom setup = new SetupRandom();
            Iteration iteration = new Iteration();
            PrintToConsole draw = new PrintToConsole();
            PrintToFile prFile = new PrintToFile();
            SetupFromFile setFrom = new SetupFromFile();
            PublicData publicData = new PublicData();
            ParalelThreadProces paralelThrProc = new ParalelThreadProces();

            Console.WriteLine(publicData.headerText);
            Console.WriteLine(publicData.matrixGeneratorOptions);
            string i = Console.ReadLine();
            int gameCount = 2;
            if (i == "f")
            {
                setup.cellBlock = setFrom.prepFromFile(gameCount);
            }
            else
            {
                setFrom.inp = Convert.ToInt32(i);
                setup.frameSetup(setFrom.inp, gameCount);
            }
            draw.drawCur(setup.cellBlock, setFrom.inp, gameCount);
            do
            {
                while (!Console.KeyAvailable)
                {
                    draw.itercount++;
                    iteration.updater(setup.cellBlock, setFrom.inp, gameCount);
                    setup.cellBlock = iteration.stepAray;
                    draw.drawCur(setup.cellBlock, setFrom.inp, gameCount);
                    Console.WriteLine(publicData.escapeText);
                    Thread.Sleep(10000);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            threadstop = false;
            Console.WriteLine(publicData.saveCurentstepText);
            string sinp = Console.ReadLine();
            if (sinp == "s")
            {
                prFile.print(setup.cellBlock, setFrom.inp, gameCount);
            }
        }
    }
}
