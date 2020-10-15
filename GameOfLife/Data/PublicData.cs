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
        public string escapeText = "Press ESC to stop game of life";
        public string saveCurentstepText = "to save to file input s key and press Enter";
    }
}
