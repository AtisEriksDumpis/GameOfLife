using GameOfLife.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameOfLife.Services
{
    class ParalelThreadProces
    {
        public void thredproceses()
        {
            SetupRandom setup = new SetupRandom();
            Iteration iteration = new Iteration();
            PrintToConsole draw = new PrintToConsole();
            PrintToFile prFile = new PrintToFile();
            SetupFromFile setFrom = new SetupFromFile();
            PublicData publicData = new PublicData();
            MainProces maine = new MainProces();

            draw.itercount = 0;
            draw.drawCur(setup.cellBlock, setFrom.inp);

                while (maine.threadstop)
                {
                    draw.itercount++;
                    iteration.updater(setup.cellBlock, setFrom.inp);
                    setup.cellBlock = iteration.stepAray;
                    draw.drawCur(setup.cellBlock, setFrom.inp);
                    Console.WriteLine(publicData.escapeText);
                    Thread.Sleep(1000);
                }
            Console.WriteLine(publicData.saveCurentstepText);
            string sinp = Console.ReadLine();
            if (sinp == "s")
            {
                prFile.print(setup.cellBlock, setFrom.inp);
            }
        }
    }
}
