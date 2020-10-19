using GameOfLife.Data;
using System;
using System.Threading;

namespace GameOfLife.Services
{
    class GameLooper
    {
        //Aray for wich 8 games to display in consloe default first eight
        public int[] displayedGameArr = { 0,1,2,3,4,5,6,7};
        public int gameCount;
        public int matrixSize;
        
        //Maine loop process to call other game generation proceses
        public bool[,,] runGame(bool[,,]startArray ,int games, string i,bool isFirst)
        {
            PublicData publicData = new PublicData();
            Cycle cycle = new Cycle();
            ConsolePrinter consolePrinter = new ConsolePrinter();
            RandomSetup randomSetup = new RandomSetup();
            FileSetup fileSetup = new FileSetup();

            randomSetup.cellBlock = startArray;
            int[] lifeStats = { 0, 0 };
            if (isFirst)
            {
                if (i == "f")
                {
                    randomSetup.cellBlock = fileSetup.prepFromFile();
                    games = fileSetup.paralelGameCount;
                    gameCount = fileSetup.paralelGameCount;
                }
                else
                {
                    fileSetup.matrixSize = Convert.ToInt32(i);
                    randomSetup.frameSetup(fileSetup.matrixSize, games);
                    gameCount = games;
                }
            }
            else if (i != "f") fileSetup.matrixSize = Convert.ToInt32(i);
            matrixSize = fileSetup.matrixSize;
            consolePrinter.drawCurentState(randomSetup.cellBlock, fileSetup.matrixSize, games, displayedGameArr, lifeStats);
            do
            {
                while (!Console.KeyAvailable)
                {
                    consolePrinter.itercount++;
                    lifeStats = cycle.updater(randomSetup.cellBlock, fileSetup.matrixSize, games);
                    randomSetup.cellBlock = cycle.stepAray;
                    consolePrinter.drawCurentState(randomSetup.cellBlock, fileSetup.matrixSize, games, displayedGameArr, lifeStats);
                    Console.WriteLine(publicData.escapeText);
                    Thread.Sleep(1000);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.P);
            return randomSetup.cellBlock;
        }
    }
}
