using GameOfLife.Data;
using GameOfLife.Services;
using System;

namespace GameOfLife
{
    //Main task list for orderly exacution. One process to call all other classes 
    class MainProcess
    {
        public bool threadstop = true;
        public void procOrd()
        {
            FilePrinter printToFile = new FilePrinter();
            PublicData publicData = new PublicData();
            GameLooper actLoop = new GameLooper();
            GameSelector slotSelect = new GameSelector();

            Console.WriteLine(publicData.headerText);
            Console.WriteLine(publicData.matrixGeneratorOptions);
            string i = Console.ReadLine();
            int gameCount = 0;
            bool isFirst = true;
            bool[,,] printMas = new bool[0,0,0];
            if (i != "f")
            {
                Console.WriteLine(publicData.selectParalelGames);
                gameCount = Convert.ToInt32(Console.ReadLine());
                printMas = new bool[Convert.ToInt32(i), Convert.ToInt32(i), gameCount];
            }
            bool shouldStop = false;
            do
            {
                printMas = actLoop.runGame(printMas, gameCount, i, isFirst);
                isFirst = false;
                Console.WriteLine(publicData.pauseScreenMenue);

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.A:
                        int sameToThis =  slotSelect.selectGame(printMas, gameCount, Convert.ToInt32(i));
                        for (int displaySlot = 0; displaySlot < 8; displaySlot++) 
                        {
                            actLoop.displayedGameArr[displaySlot] = sameToThis;
                        }
                        break;
                    case ConsoleKey.S:
                        printToFile.print(printMas, Convert.ToInt32(i), gameCount);
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Input wich slot from 1 to 8 to change:");
                        int slotNum = Convert.ToInt32(Console.ReadLine());
                        actLoop.displayedGameArr[slotNum-1]= slotSelect.selectGame(printMas, gameCount, Convert.ToInt32(i));
                        break;
                    case ConsoleKey.Escape:
                        shouldStop = true;
                        break;
                }
            } while (!shouldStop);
        }
    }
}
