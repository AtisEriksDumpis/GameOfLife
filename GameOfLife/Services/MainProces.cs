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

            Thread[] paralelGames = new Thread[1];


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
            for (int k = 0; k < paralelGames.Length; k++)
            {
                paralelGames[k] = new Thread(new ThreadStart(paralelThrProc.thredproceses));
                paralelGames[k].Start();
            }
            draw.drawCur(setup.cellBlock, setFrom.inp);
            do
            {
                while (!Console.KeyAvailable)
                {

                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            threadstop = false;
            Console.WriteLine(publicData.saveCurentstepText);
            string sinp = Console.ReadLine();
            if (sinp == "s")
            {
                prFile.print(setup.cellBlock, setFrom.inp);
            }
        }
    }
}
