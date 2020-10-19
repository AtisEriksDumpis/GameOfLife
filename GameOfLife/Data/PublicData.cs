using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Data
{
    class PublicData
    {
        public string headerText = "___GAME OF LIFE___";
        public string matrixGeneratorOptions = "To contineu from last saved games instance pres f if not input size of matixes ege";
        public int neighbourCountTwo = 2;
        public int neighbourCountThree = 3;
        public string liveCellCount = "Curently alive cells: ";
        public string iterrationCounter = "Current iteration of matrix: ";
        public string escapeText = "Press P to pause Game of life";
        public string saveCurentstepText = "to save to file input s key and press Enter";
        public string selectParalelGames = "Please input the number of paralel games";
        public string pauseScreenMenue = "Game paused please select next action for game: \n 1) press [C] to change selected games \n 2) press [A] to same all games \n 3) press [S] to select and save game \n 4) press [ESC] to exit game";
        public string endProcesText = "Do you want to exit game then pres [N] otherwise pres any other key";

    }
}
