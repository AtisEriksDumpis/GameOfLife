using GameOfLife.Data;
using System;
using System.Threading;

namespace GameOfLife.Services
{
    class GameLooper
    {
        public int[] displayedGameArr = { 0,1,2,3,4,5,6,7};
        public bool[,,] runGame(bool[,,]startArray ,int games, string i,bool isFirst)
        {
            PublicData publicData = new PublicData();
            Cycle iteration = new Cycle();
            ConsolePrinter draw = new ConsolePrinter();
            RandomSetup setup = new RandomSetup();
            FileSetup setFrom = new FileSetup();

            setup.cellBlock = startArray;
            int[] liveCells = { 0, 0 };
            if (isFirst)
            {
                if (i == "f") setup.cellBlock = setFrom.prepFromFile(games);
                else
                {
                    setFrom.inp = Convert.ToInt32(i);
                    setup.frameSetup(setFrom.inp, games);
                }
            }
            else if (i != "f")setFrom.inp = Convert.ToInt32(i);
            draw.drawCur(setup.cellBlock, setFrom.inp, games, displayedGameArr, liveCells);
            do
            {
                while (!Console.KeyAvailable)
                {
                    draw.itercount++;
                    liveCells =  iteration.updater(setup.cellBlock, setFrom.inp, games);
                    setup.cellBlock = iteration.stepAray;
                    draw.drawCur(setup.cellBlock, setFrom.inp, games, displayedGameArr, liveCells);
                    Console.WriteLine(publicData.escapeText);
                    Thread.Sleep(1000);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.P);
            return setup.cellBlock;
        }
    }
}
